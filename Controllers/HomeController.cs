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
        ViewBag.Paquetes = ORTWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete()
    {
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        return View();
    }

    public IActionResult GuardarPaquete(string Destino, string Hotel, string Aereo, string Excursion)
    {
        if (Destino == "" || Hotel == "" || Aereo == "" || Excursion == "") //esta se puede mejorar
        {
            ViewBag.ErrorMessage = "Todos los campos son obligatorios.";
            ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
            ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
            ViewBag.ListaAereos = ORTWorld.ListaAereos;
            ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
            return View("CrearPaquete"); 
        }

        var nuevoPaquete = new Paquete(Destino, Hotel, Aereo,Excursion );

        ORTWorld.IngresarPaquete(Destino, nuevoPaquete);

        ViewBag.Paquetes = ORTWorld.Paquetes;
        return RedirectToAction("Index");
    }

}