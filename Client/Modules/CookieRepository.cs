using Microsoft.JSInterop;
using MVSRA.Shared.Modules;

namespace MVSRA.Client.Modules
{
    public class CookieRepository(IJSRuntime jsRuntime) : ICookie
    {
        #region Fields
        readonly IJSRuntime JSRuntime = jsRuntime;
        readonly string expirationDate = DateToUTC(300);

        private const string LAST_VISIT = "LastVisit";
        private const string DISABLE_COOKIES = "DisableCookies";

        private bool cookiesDisabled = false;
        #endregion

        #region PublicMethods
        public async Task SetValue(string key, string value, int? days = null)
        {
            var curExp = (days != null) ? (days > 0 ? DateToUTC(days.Value) : "") : expirationDate;
            await SetCookie($"{key}={value}; expires={curExp}; path=/");
        }

        public async Task<string> GetValue(string key, string def = "")
        {
            var cValue = await GetCookie();
            if (string.IsNullOrEmpty(cValue)) return def;

            var vals = cValue.Split(';');
            foreach (var val in vals)
                if (!string.IsNullOrEmpty(val) && val.IndexOf('=') > 0)
                    if (val[..val.IndexOf('=')].Trim().Equals(key, StringComparison.OrdinalIgnoreCase))
                        return val[(val.IndexOf('=') + 1)..];
            return def;
        }

        public async Task<bool> IsNewUser()
        {
            string disableCookies = await GetValue(DISABLE_COOKIES);
            if (disableCookies == "true")
            {
                cookiesDisabled = true;
                return false;
            }

            string lastVisitCookie = await GetValue(LAST_VISIT);
            return string.IsNullOrWhiteSpace(lastVisitCookie);
        }

        public async Task SetNewUser(bool disableCookies = false)
        {
            if (disableCookies == true)
            {
                await SetValue(DISABLE_COOKIES, "true");

                cookiesDisabled = true;
                return;
            }

            await SetValue(LAST_VISIT, DateTime.Now.ToShortDateString());
        }
        #endregion

        #region AsyncMethods
        private async Task SetCookie(string value)
        {
            if (cookiesDisabled) return;

            await JSRuntime.InvokeVoidAsync("eval", $"document.cookie = \"{value}\"");
        }

        private async Task<string> GetCookie()
        {
            if (cookiesDisabled) return string.Empty;

            return await JSRuntime.InvokeAsync<string>("eval", $"document.cookie");
        }
        #endregion

        #region Methods
        private static string DateToUTC(int days) => DateTime.Now.AddDays(days).ToUniversalTime().ToString("R");
        #endregion
    }
}