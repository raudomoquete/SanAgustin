using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class Cargos
    {
        [Key]
        [DisplayName("Id del Cargo")]
        public int CargoId { get; set; }
        [DisplayName("Nombre del Cargo")]
        public string NombreCargo { get; set; }
    }
}