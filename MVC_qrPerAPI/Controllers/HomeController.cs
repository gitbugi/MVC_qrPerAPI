using Microsoft.AspNetCore.Mvc;
using MVC_qrPerAPI.Models;
using System.Drawing;

namespace MVC_qrPerAPI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IndexView indexView)
        {
            ViewBag.src = $"https://image-charts.com/chart?chs={indexView.Hoehe}x{indexView.Breite}&cht=qr&chl={indexView.Url}&icqrf={ToHex(indexView.VF)}&icqrb={ToHex(indexView.HF)}&choe=UTF-8";
            return View(indexView);
        }

        private static String ToHex(Color c) => $"{c.R:X2}{c.G:X2}{c.B:X2}";
    }
}
