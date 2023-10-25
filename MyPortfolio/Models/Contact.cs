using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Contact
    {
        [Required (ErrorMessage = "این فیلد اجباری است.")]
        [MinLength(3,ErrorMessage = "حدعقل 3 کارکتر را وارد نمایید.")]
        [MaxLength(100,ErrorMessage = "حداکثر 100 کارکتر را می باشد.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است.")]
        public string Phone { get; set; }
        public string Subtitle { get; set; }
        public string Message { get; set; }



    }


}