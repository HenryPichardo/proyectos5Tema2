using Proyecto5Tema2_Diplomado_Web_MVC_UASD_Pelicula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto5Tema2_Diplomado_Web_MVC_UASD_Pelicula.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var peliculas = new List<Pelicula>
            {
                new Pelicula {Titulo = "The Godfather", Director = "Francis Ford Coppola", ActorPrincipal = "Al Pacino", NumActores = 30, Duracion = 2, FechaEstreno = 1994 },
                new Pelicula {Titulo = "The Shawshank", Director = "Frank Darabont", ActorPrincipal = "Morgan Freeman", NumActores = 15, Duracion = 3, FechaEstreno = 1972 },
                new Pelicula {Titulo = "The Matrix", Director = "Lana Wachowski", ActorPrincipal = "Keanu Reeves", NumActores = 15, Duracion = 2.30, FechaEstreno = 1999 },
                new Pelicula {Titulo = "City of God", Director = "Fernando Meirelles", ActorPrincipal = "Alexandre Rodriguez", NumActores = 10, Duracion = 3, FechaEstreno = 2002 },
                new Pelicula {Titulo = "Star War : Episode IV", Director = "George Lucas", ActorPrincipal = "Harrison Ford", NumActores = 20, Duracion = 2.40, FechaEstreno = 2007 }

            };
            //return View(peliculas);

            var resultPeliculas = from Pelicula in peliculas
                                  where Pelicula.Titulo.Contains("The")
                                  select Pelicula;
            return View(resultPeliculas);
        }
    }
}