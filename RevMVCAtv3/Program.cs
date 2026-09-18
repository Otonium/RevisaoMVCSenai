// Importar EF Core
using Microsoft.EntityFrameworkCore;
// Importar a pasta onde está o arquivo AppDbContext
// using NAMESPACE_PROJETO.Data; // ficará válido depois do scaffold

// 1. Primeiro você declara e cria o builder
var builder = WebApplication.CreateBuilder(args);

// 2. Depois você usa o builder para configurar os serviços
builder.Services.AddControllers();

var app = builder.Build();
app.Run();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HomeController}/{action=Index}/{id?}")
    .WithStaticAssets();