using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_AdanArdayaDominguez.Models
{
    public class Curreny
    {   [key]
        public string name { get; set; }
        [Required]
        public string Code { get; set; }
        [StringLength(30, MinimumLength = 3, ErrorMessage = "INGRESE ENTRE 1 A 5 CARACTERES")]

        public string Symbol { get; set; }
    }
}