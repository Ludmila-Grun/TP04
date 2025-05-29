using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

   public IActionResult Index()
    {
        return View();
    }


    public IActionResult ComenzarJuego()
    {
        JuegoAhorcado.ComenzarJuego();
        ViewBag.PalabraSeVe = JuegoAhorcado.AdivinarPalabra();
        ViewBag.LetrasIntentadas = JuegoAhorcado.ListaLetrasIntentadas;
        ViewBag.Contador = JuegoAhorcado.Contador;
        ViewBag.PalabraAdivinar = JuegoAhorcado.PalabraAdivinar;
        return View("Juego");
    }


 


  public IActionResult ProbarLetra(char letra)
    {
        ViewBag.PalabraSeVe = JuegoAhorcado.ProbarLetra(letra);
        ViewBag.LetrasIntentadas = JuegoAhorcado.ListaLetrasIntentadas;
        ViewBag.Contador = JuegoAhorcado.Contador;
        ViewBag.palabraAdivinar = JuegoAhorcado.PalabraAdivinar;


        if (!ViewBag.PalabraSeVe.Contains("_"))
        {
            ViewBag.Final = true;
            return View("Resultado");
        }


        return View("Juego");
    }

    
    public IActionResult ProbarPalabra(string palabra)
    {
        ViewBag.Final = JuegoAhorcado.ProbarPalabra(palabra);
        ViewBag.PalabraSeVe = JuegoAhorcado.AdivinarPalabra();
        ViewBag.LetrasIntentadas = JuegoAhorcado.ListaLetrasIntentadas;
        ViewBag.Contador = JuegoAhorcado.Contador;
        ViewBag.PalabraAdivinar = JuegoAhorcado.PalabraAdivinar;
        return View("MostrarResultados");
    }


}
