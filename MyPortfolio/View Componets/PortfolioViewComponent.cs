using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.View_Componets
{
    public class PortfolioViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Portfolios = new List<Portfolio>
            {
                new Portfolio(1,"طراحی سایت 1","و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی","Portfolio1 .jpg"),
                new Portfolio(2,"طراحی سایت 2","و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی","Portfolio1 .jpg"),
                new Portfolio(3,"طراحی سایت 3","و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی","Portfolio1 .jpg"),
                new Portfolio(4,"طراحی سایت 4","و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی","Portfolio1 .jpg"),
                new Portfolio(5,"طراحی سایت 5","و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی","Portfolio1 .jpg"),
                new Portfolio(6,"طراحی سایت 6","و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی","Portfolio1 .jpg"),
            };
            return View("_portfolio", Portfolios);
        }
    }
}
