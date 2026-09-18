// Importar EF Core
using Microsoft.EntityFrameworkCore;
// Importar a pasta onde está o arquivo AppDbContext
// using NAMESPACE_PROJETO.Data; // ficará válido depois do scaffold

// registra o DbContext (o namespace/classe virão do scaffold)
builder.Services.AddDbContext<NAMESPACE_PROJETO.Data.AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=HomeController}/{action=Index}/{id?}")
//     .WithStaticAssets();