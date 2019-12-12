using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class Personal
    {
        [Key]
        [DisplayName("Id")]
        public int PersonalId { get; set; }
        [DisplayName("Nombres")]
        public string Nombres { get; set; }
        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }
        [DisplayName("Cedula")]
        public string Cedula { get; set; }
        [DisplayName("Telefono")]
        public string Telefono { get; set; }
        [DisplayName("Direccion")]
        public string Direccion { get; set; }
        [DisplayName("Comunidad")]
        public string Comunidad { get; set; }
        [DisplayName("Cargo")]
        public string Cargo { get; set; }

    }
}