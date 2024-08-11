namespace MVSRA.Shared.Modules;

public interface ICookie
{
    Task SetValue(string key, string value, int? days = null);
    Task<string> GetValue(string key, string def = "");
}
