using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using shopping_cart_.Data;
using shopping_cart_.Models;

var builder = WebApplication.CreateBuilder(args);
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<DbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MvcProductContext")));
}
else
{
    builder.Services.AddDbContext<DbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionMvcProductContext")));
}




builder.Services.AddDbContext<MvcProductContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcProductContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
