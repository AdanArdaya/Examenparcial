using NetTopologySuite.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_AdanArdayaDominguez.Models

{
    public class Producto

    {   [key]
        public int ProductoID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "INGRESE ENTRE 1 A 5 CARACTERES")]
        public string Descripcion  { get; set; }
        public List<Curreny> Cuerrencies  { get; set; }

      
    }
}