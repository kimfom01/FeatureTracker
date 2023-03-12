using ProjectManager.Context;
using ProjectManager.Helper;
using ProjectManager.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<FeatureDbContext>(options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString("FeatureDb"));
    });
}
else
{
    builder.Services.AddDbContext<FeatureDbContext>(options =>
    {
        options.UseNpgsql(ExternalDbConnectionHelper.GetConnectionString());
    });
}

builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

if (app.Environment.IsProduction())
{
    // Apply pending migrations on database
    var scope = app.Services.CreateScope();
    await MigrationHelper.ManageDataAsync(scope.ServiceProvider);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
