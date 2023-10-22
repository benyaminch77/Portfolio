using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolios = new List<Portfolio>()
        {
            new Portfolio
            {
                Id = 1, Title = "طراحی سایت 1", Image = "Portfolio1 .jpg",
                Description = "و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی"
            },
            new Portfolio
            {
                Id = 2, Title = "طراحی سایت 1", Image = "Portfolio1 .jpg",
                Description = "و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی"
            },
            new Portfolio
            {
                Id = 3, Title = "طراحی سایت 1", Image = "Portfolio1 .jpg",
                Description = "و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی"
            },
            new Portfolio
            {
                Id = 4, Title = "طراحی سایت 1", Image = "Portfolio1 .jpg",
                Description = "و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی"
            },
            new Portfolio
            {
                Id = 5, Title = "طراحی سایت 1", Image = "Portfolio1 .jpg",
                Description = "و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی"
            },
            new Portfolio
            {
                Id = 6, Title = "طراحی سایت 1", Image = "Portfolio1 .jpg",
                Description = "و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی"
            },

        };
        public IActionResult Index()
        {
            var Contact = new Contact()
            {
                Email = "benyaminchoopanii@gmail.com",
                Phone = "09117788529",
                Instagram = "instagram.com/benyamin_chupani"
            };


            return View(_portfolios);
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult SeevicesSectionOne()
        {
            return View();
        }

        public IActionResult SeevicesSectionTwo()
        {
            return View();
        }

        public IActionResult SeevicesSectionTree()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
