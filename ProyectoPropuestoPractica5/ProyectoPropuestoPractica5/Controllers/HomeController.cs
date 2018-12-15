using ProyectoPropuestoPractica5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPropuestoPractica5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
                  
            var articulos = new List<Producto>
            {
                new Producto{ID=1,Descripcion="Boligrafo",Precio=8.35},
                new Producto{ID=2,Descripcion="Cuaderno Grande",Precio=21.5},
                new Producto{ID=3,Descripcion="Cuaderno Pequeño",Precio=10},
                new Producto{ID=4,Descripcion="Folios 500 unds.",Precio=550.55},
                new Producto{ID=5,Descripcion="Grapadora",Precio=85.25},
                new Producto{ID=6,Descripcion="Tijeras",Precio=62},
                new Producto{ID=7,Descripcion="Cinta Adhesiva",Precio=42.10},
                new Producto{ID=8,Descripcion="Rotulador",Precio=20.75},
                new Producto{ID=9,Descripcion="Mochila Escolar",Precio=800.90},
                new Producto{ID=10,Descripcion="Pegamento Barra",Precio=30.15},
                new Producto{ID=11,Descripcion="Lapicero",Precio=15.55},
                new Producto{ID=12,Descripcion="Grapas",Precio=40.90},
                new Producto{ID=13,Descripcion="Portaminas",Precio=8.35}
            };
            //return View(articulos);
            //var descripLetraI = from Producto in articulos
            //                      where Producto.Descripcion.Contains("I")
            //                      select Producto;
            //return View(descripLetraI);

            //var descripLetraC = from Producto in articulos
            //                    where Producto.Descripcion.StartsWith("C")
            //                    select Producto;
            //return View(descripLetraC);

            //var descripLetraO = from Producto in articulos
            //                    where Producto.Descripcion.EndsWith("O")
            //                    select Producto;
            //return View(descripLetraO);

            //var precioMayor20 = from Producto in articulos
            //                    where Producto.Precio > 20
            //                    select Producto;
            //return View(precioMayor20);

            var precioMenor70 = from Producto in articulos
                                where Producto.Precio < 70
                                select Producto;
            return View(precioMenor70);

        }
    }
}