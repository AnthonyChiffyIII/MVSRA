//using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using MudBlazor.Services;
using MVSRA.Server.EFContext;
using MVSRA.Server.Modules;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddScoped<PhotoRepository>();
builder.Services.AddScoped<MeetingRepository>();

// Add Authorization
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//});

// Add Database
builder.Services.AddDbContextFactory<MVSRAContext>(options =>
{
    string? connectionString = builder.Configuration.GetConnectionString("Database");
    if (connectionString is not null)
    {
        options.UseSqlServer(
            connectionString,
            builder => builder.MigrationsAssembly("MVSRA.Server")
                .MigrationsHistoryTable(HistoryRepository.DefaultTableName, "MVSRA")
        );
    }
});

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();