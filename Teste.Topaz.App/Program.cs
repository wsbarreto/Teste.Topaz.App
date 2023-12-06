using Microsoft.EntityFrameworkCore;
using Teste.Topaz.App.Data.Context;
using Teste.Topaz.App.Data.Repository;
using Teste.Topaz.App.Domain.Interface.Repository;
using Teste.Topaz.App.Domain.Interface.Service;
using Teste.Topaz.App.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// DI
builder.Services.AddScoped<ICompactDiscService, CompactDiscService>();
builder.Services.AddScoped<ICompactDiscRepository, CompactDiscRepository>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings")["connectionString"]);
});

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