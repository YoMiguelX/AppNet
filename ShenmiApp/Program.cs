using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShenmiApp.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. PRIMERO: Obtener la cadena de conexi�n
var conString = builder.Configuration.GetConnectionString("conexion") ??
    throw new InvalidOperationException("Error: cadena de conexi�n 'conexion' no encontrada.");

// 2. Registrar DbContext principal
builder.Services.AddDbContext<ShenmiContext>(options =>
    options.UseMySql(
        conString,
        ServerVersion.Parse("10.4.32-mariadb")
    )
);

// 3. Registrar DbContext de Identity (si ApplicationDbContext es diferente)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(conString, ServerVersion.AutoDetect(conString))
);

// 4. Configurar Identity
builder.Services
    .AddDefaultIdentity<ApplicationUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        // Reglas de contrase�a relajadas para desarrollo:
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 6;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// 5. Otros servicios
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication(); // �IMPORTANTE! Agregar antes de UseAuthorization
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); // Necesario para las p�ginas de Identity

app.Run();