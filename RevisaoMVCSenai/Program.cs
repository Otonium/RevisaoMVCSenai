var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte ao MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura o tratamento de erros
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Redireciona HTTP para HTTPS
app.UseHttpsRedirection();

// Permite acessar arquivos como CSS, JavaScript e imagens
app.UseStaticFiles();

app.UseRouting();

// Configura a rota padrão do MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();