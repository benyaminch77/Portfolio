using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.View_Componets
{
    public class ContentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var contants = new List<Contact>
            {
                new Contact("benyaminchoopanii@gmail.com", "09117788529","instagram.com/benyamin_chupani"),
            };
            return View("_Content", contants);
        }
    }
}
