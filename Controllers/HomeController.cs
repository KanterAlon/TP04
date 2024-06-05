using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_PaquetesTuristicos_Final.Models;

namespace TP04_PaquetesTuristicos_Final.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
            ORTWorld ortWorld = new ORTWorld();

            ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
            ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
            ViewBag.ListaAereos = ORTWorld.ListaAereos;
            ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;

            return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

        private List<string> ListaDestinos;
        private List<string> ListaHoteles;
        private List<string> ListaAereos;
        private List<string> ListaExcursiones;
        private Dictionary<string, Paquete> Paquetes;

        public IActionResult SelectPaquete()
        {
            ListaDestinos = ORTWorld.ListaDestinos;
            ListaHoteles = ORTWorld.ListaHoteles;
            ListaAereos = ORTWorld.ListaAereos; 
            ListaExcursiones = ORTWorld.ListaExcursiones;
            
            ViewBag.ListaDestinos = ListaDestinos;
            ViewBag.ListaHoteles = ListaHoteles;
            ViewBag.ListaAereos = ListaAereos;
            ViewBag.ListaExcursiones = ListaExcursiones;
            return View();
        }

        public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
        {
            if (Destino != -1 && Hotel != -1 && Aereo != -1 && Excursion != -1)
            {
                Paquete paquete = new Paquete(ORTWorld.ListaDestinos[Destino], ORTWorld.ListaHoteles[Hotel], ORTWorld.ListaAereos[Aereo], ORTWorld.ListaExcursiones[Excursion]);
                ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino], paquete);
                
                ListaDestinos = ORTWorld.ListaDestinos;
                ListaHoteles = ORTWorld.ListaHoteles;
                ListaAereos = ORTWorld.ListaAereos; 
                ListaExcursiones = ORTWorld.ListaExcursiones;
                
                ViewBag.ListaDestinos = ListaDestinos;
                ViewBag.ListaHoteles = ListaHoteles;
                ViewBag.ListaAereos = ListaAereos;
                ViewBag.ListaExcursiones = ListaExcursiones;

                return View();

            }
            else
            {
                ViewBag.MensajeDeError = "Todos los campos son obligatorios. Por favor, seleccione una opción para cada categoría.";
                return View();
            }
        }
}
