using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.View_Componets
{
    public class ServiceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Services = new List<Service>
            {
                new Service(1, "توسعه دهنده وب", "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و بااستفاده از طراحان گرافیک است،<br />چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی<br />لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و بااستفاده از طراحان گرافیک است،", "bx bx-code-alt"),
                new Service(2, "طراح گرافیک", "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و بااستفاده از طراحان گرافیک است،<br />چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی<br />لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و بااستفاده از طراحان گرافیک است،", "bx bxs-paint"),
                new Service(3, "دیجیتال مارکتینگ", "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و بااستفاده از طراحان گرافیک است،<br />چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی<br />لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و بااستفاده از طراحان گرافیک است،", "bx bx-bar-chart-alt"),
            };
            return View("_Service", Services);
        }
    }
}
