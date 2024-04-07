using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using MVSRA.Server.EFContext;
using MVSRA.Server.Modules;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<PhotoRepository>();

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
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
