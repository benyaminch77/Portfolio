using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Service
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string Icon { get; set; }

        public Service(long id, string title, string discription, string icon)
        {
            Id = id;
            Title = title;
            Discription = discription;
            Icon = icon;
        }
    }
}
