using Microsoft.EntityFrameworkCore;
using RevisaoMVCAtividade2.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona MVC
builder.Services.AddControllersWithViews();

// Pega a conexão do appsettings.json
var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");

// Configura o Entity Framework para usar SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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