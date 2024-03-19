using FarmaciaIntegral.Models;
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
        var productos = ObtenerInstancia().ObtenerProductos();
        return View(model: productos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public List<Productos> ObtenerProductos()
    {
        List<Productos> productos = new List<Productos>();

        productos.Add(new Productos
        {
            Codigo = "001",
            Nombre = "Producto 1",
            Descripcion = "Descripción del Producto 1",
            Calidad = 5,
            Especificaciones = "Especificaciones del Producto 1",
            FechaDeVencimiento = DateTime.Now.AddDays(30)
        });

        productos.Add(new Productos
        {
            Codigo = "002",
            Nombre = "Producto 2",
            Descripcion = "Descripción del Producto 2",
            Calidad = 4,
            Especificaciones = "Especificaciones del Producto 2",
            FechaDeVencimiento = DateTime.Now.AddDays(45)
        });

        productos.Add(new Productos
        {
            Codigo = "003",
            Nombre = "Producto 3",
            Descripcion = "Descripción del Producto 3",
            Calidad = 3,
            Especificaciones = "Especificaciones del Producto 3",
            FechaDeVencimiento = DateTime.Now.AddDays(60)
        });

        productos.Add(new Productos
        {
            Codigo = "004",
            Nombre = "Producto 4",
            Descripcion = "Descripción del Producto 4",
            Calidad = 2,
            Especificaciones = "Especificaciones del Producto 4",
            FechaDeVencimiento = DateTime.Now.AddDays(75)
        });

        productos.Add(new Productos
        {
            Codigo = "005",
            Nombre = "Producto 5",
            Descripcion = "Descripción del Producto 5",
            Calidad = 1,
            Especificaciones = "Especificaciones del Producto 5",
            FechaDeVencimiento = DateTime.Now.AddDays(90)
        });

        return productos;
    }
}
