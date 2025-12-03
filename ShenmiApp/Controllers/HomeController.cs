using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShenmiApp.Data;

public class HomeController : Controller
{
    private readonly ShenmiContext _context;

    public HomeController(ShenmiContext context)
    {
        _context = context;
    }

    // 👉 AGREGAR ESTE MÉTODO
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult TestBD()
    {
        try
        {
            bool conectado = _context.Database.CanConnect();
            return Content("¿Conectado a la BD? → " + conectado);
        }
        catch (Exception ex)
        {
            return Content("Error al conectar: " + ex.Message);
        }
    }
}

