using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class Comunidades
    {
        [Key]
        [DisplayName("Id de la Comunidad")]
        public string ComunidadId { get; set; }
        [DisplayName("Nombre Comunidad")]
        public string NombreComunidad { get; set; }
    }
}