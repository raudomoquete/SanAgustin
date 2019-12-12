using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class InfAdicional
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Genero")]
        public string Genero { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [DisplayName("Nacionalidad")]
        public string Nacionalidad { get; set; }
        [DisplayName("Nivel Academico")]
        public string NivelAcademico { get; set; }
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }
        public string Imagen { get; set; }
    }
}