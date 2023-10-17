using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Series.Models;

namespace Series.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.listaTemporadas = BD.LevantarTemporadas();
        ViewBag.listaActores = BD.LevantarActores();
        ViewBag.listaSeries = BD.LevantarSeries();
        foreach(Serie ser in ViewBag.listaSeries){
            ViewBag.IdSerie = ser.IdSerie;
        }
        foreach(Actores act in ViewBag.listaActores){
            ViewBag.IdActor = act.IdActor;
        }
        foreach(Temporadas temp in ViewBag.listaTemporadas){
            ViewBag.IdTemporada = temp.IdTemporada;
        }
        return View("Index");
    }

    public Actores VerActoresAjax(){
        ViewBag.Actores = BD.LevantarActores();
        return ViewBag.Actores;
    }

    public Temporadas VerTemporadasAjax(){
        ViewBag.Temporadas = BD.LevantarTemporadas();
        return ViewBag.Temporadas;
    }

    public Serie VerMasInfoAjax(){
        ViewBag.Series = BD.LevantarSeries();
        return ViewBag.Series;
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
}
