using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Contact
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Instagram { get; set; }

        public Contact(string email, string phone, string instagram)
        {
            Email = email;
            Phone = phone;
            Instagram = instagram;
        }
        
    }


}
