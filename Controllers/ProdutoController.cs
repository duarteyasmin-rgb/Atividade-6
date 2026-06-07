using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjetoMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>()
            {
                "Mouse",
                "Teclado",
                "Monitor",
                "Notebook",
                "Headset"
            };

            List<double> precos = new List<double>()
            {
                50.00,
                80.00,
                750.00,
                3500.00,
                120.00
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}