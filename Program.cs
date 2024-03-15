using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MVSRA;
using MudBlazor.Services;
using MVSRA.EFContext;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Custom Services
builder.Services.AddMudServices();

builder.Services.AddOidcAuthentication(options =>
{
    builder.Configuration.Bind("Auth0", options.ProviderOptions);
    options.ProviderOptions.ResponseType = "code";
});

builder.Services.AddDbContextFactory<MVSRAContext>(options =>
{
    string? connectionString = builder.Configuration.GetConnectionString("Database");
    if (connectionString is not null)
    {
        options.UseSqlServer(connectionString, builder => builder.MigrationsAssembly("MVSRA"));
    }
});

await builder.Build().RunAsync();
