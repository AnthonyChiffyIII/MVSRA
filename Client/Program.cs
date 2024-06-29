using BlazingApple.Forums.Components.Extensions;
using BlazingApple.Forums.Shared.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using MVSRA.Client;
using MVSRA.Client.Modules;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add Services
builder.Services.AddMudServices();
builder.Services.AddHttpClient(string.Empty, x => x.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddForums(builder.Configuration);
builder.Services.AddFakeForumServices();
builder.Services.AddSingleton<CookieRepository>();
builder.Services.AddSingleton<PhotoRepository>();
builder.Services.AddSingleton<MeetingRepository>();


// Add Authorization
builder.Services.AddOidcAuthentication(options =>
{
    builder.Configuration.Bind("Auth0", options.ProviderOptions);
    options.ProviderOptions.ResponseType = "code";
});

await builder.Build().RunAsync();
