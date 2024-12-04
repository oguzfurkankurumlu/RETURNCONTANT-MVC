using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RETURNCONTANT_MVC.Models;

namespace RETURNCONTANT_MVC.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetContent()
    {
        //return Content("https://www.google.com");
        // content metodu: Bir IActionResult döndürür ve istemciye metin verisi iletir.
        // CONTENT BİR VİEW DEGILDIR BU ACTIONA GELINDIGINDE EKRANA SADECE DUZ BIR METIN GOZUKECEKTIR.
        // BUTONA TIKLADIGINDA VİEW YERINE BIR YAZI CIKSIN ISTERSENIZ RETURN CONTENT KULLANABILIRSINIZ.
        // content duz bır metın dondu burda


        // return content geriye json veride dönebilir!!
        // Json veriye ne ihtiyacımız var, eğer mvcdeki bir action'u, javascript fetch metodu ile kullanacaksak,
        // fetch metodu json veriye göre cevap vermek için, return content içerisinde json veri verilebilir!!
        //return Content("{\"message\":\"ben bir jsonum\"}");


        // return json ile bir tipi direkt json tipine cevirebiliriz.
        // json tipine cevirdigimiz tipi, index view'da javascript fetch metodu ile kullanabiliriz.
        return Json(new IndexViewModel()
        {
            Description = "Bu ürün piyasanın en iyisi",
            Name = "Vestel Klima",
            Id = 5,
        });



    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
