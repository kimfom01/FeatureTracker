using Data.Context;
using Data.DataHelper;
using Data.Repositories;
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

var app = builder.Build();

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
