using Microsoft.EntityFrameworkCore;
using CrudProject.Data; // Ensure the correct namespace

var builder = WebApplication.CreateBuilder(args);

// Retrieve Connection String
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register MySQL DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 32)))); // Match your MySQL version

// Add Controllers with Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Employee}/{action=Index}/{id?}");
});

app.Run();

