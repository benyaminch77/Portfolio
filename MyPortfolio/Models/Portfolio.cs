﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Portfolio
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string Image { get; set; }

        public Portfolio(long id, string title, string discription, string image)
        {
            Id = id;
            Title = title;
            Discription = discription;
            Image = image;
        }
    }
}