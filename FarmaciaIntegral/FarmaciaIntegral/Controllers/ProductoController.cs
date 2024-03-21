using FarmaciaIntegral.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmaciaIntegral.Controllers
{
    public class ProductoController : Controller
    {
        private static readonly object lockObject = new object();
        private static ProductoController instance;
        public  List<Productos> listaProductos = new List<Productos>();

        public static ProductoController ObtenerInstancia()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ProductoController();
                        instance.ObtenerProductos();
                    }
                }
            }
            return instance;
        }

        public IActionResult Index()
        {
            if (!listaProductos.Any())
                listaProductos = ObtenerProductos();
            return View(model: listaProductos);
        }

        public List<Productos> ObtenerProductos()
        {
            
            listaProductos.Add(new Productos
            {
                Codigo = "001",
                Nombre = "Producto 1",
                Descripcion = "Descripción del Producto 1",
                Calidad = 5,
                Especificaciones = "Especificaciones del Producto 1",
                FechaDeVencimiento = DateTime.Now.AddDays(30)
            });

            listaProductos.Add(new Productos
            {
                Codigo = "002",
                Nombre = "Producto 2",
                Descripcion = "Descripción del Producto 2",
                Calidad = 4,
                Especificaciones = "Especificaciones del Producto 2",
                FechaDeVencimiento = DateTime.Now.AddDays(45)
            });

            listaProductos.Add(new Productos
            {
                Codigo = "003",
                Nombre = "Producto 3",
                Descripcion = "Descripción del Producto 3",
                Calidad = 3,
                Especificaciones = "Especificaciones del Producto 3",
                FechaDeVencimiento = DateTime.Now.AddDays(60)
            });

            listaProductos.Add(new Productos
            {
                Codigo = "004",
                Nombre = "Producto 4",
                Descripcion = "Descripción del Producto 4",
                Calidad = 2,
                Especificaciones = "Especificaciones del Producto 4",
                FechaDeVencimiento = DateTime.Now.AddDays(75)
            });

            listaProductos.Add(new Productos
            {
                Codigo = "005",
                Nombre = "Producto 5",
                Descripcion = "Descripción del Producto 5",
                Calidad = 1,
                Especificaciones = "Especificaciones del Producto 5",
                FechaDeVencimiento = DateTime.Now.AddDays(90)
            });

            return listaProductos;
        }
    }
}
