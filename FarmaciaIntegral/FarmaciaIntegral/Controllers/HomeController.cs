using FarmaciaIntegral.Controllers;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private static readonly object lockObject = new object();
    private static HomeController instance;

    public static HomeController ObtenerInstancia()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new HomeController();
                }
            }
        }
        return instance;
    }

    public IActionResult Index()
    {
        var productos = ProductoController.ObtenerInstancia().listaProductos;
        return View(model: productos);
    }
   
}
