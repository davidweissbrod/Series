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
        ViewBag.listaSeries = BD.LevantarSeries();
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

    public Serie VerMasInfo(){
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
