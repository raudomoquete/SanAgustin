using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class Bodas
    {
        [Key]
        [DisplayName("Id de la Boda")]
        [Required(ErrorMessage = "Este Campo es Requerido!")]
        public int BodaId { get; set; }
        [DisplayName("Nombres de los Novios")]
        public string Casados { get; set; }
        [DisplayName("Nombres del Novio")]
        public string NombreNovio { get; set; }
        [DisplayName("Cedula del Novio")]
        public string CedNovio { get; set; }
        [DisplayName("Nombre de la Novia")]
        public string NombreNovia { get; set; }
        [DisplayName("Cedula de la Novia")]
        public string CedNovia { get; set; }
        [DisplayName("Fecha de la Novia")]
        public DateTime FechaBoda { get; set; }
        [DisplayName("Lugar de la Boda")]
        public string LugarBoda { get; set; }
        [DisplayName("Padrino de la Boda")]
        public string PadrinoBoda { get; set; }
        [DisplayName("Cedula del Padrino")]
        public string CedPadrino { get; set; }
        [DisplayName("Madrina de la Boda")]
        public string MadrinaBoda { get; set; }
        [DisplayName("Cedula de la Madrina")]
        public string CedMadrina { get; set; }
        [DisplayName("Representante")]
        public string NombreRepresentante { get; set; }
        [DisplayName("Cedula del Representante")]
        public string CedRepresentante { get; set; }
        [DisplayName("Cedula del Representante")]
        public string Comentario { get; set; }
        [DisplayName("Testigo 1")]
        public string Testigo1 { get; set; }
        [DisplayName("Cedula del Testigo")]
        public string CedTestigo1 { get; set; }
        [DisplayName("Segundo Testigo")]
        public string Testigo2 { get; set; }
        [DisplayName("Cedula del segundo Testigo")]
        public string CedTestigo2 { get; set; }
        [DisplayName("Celebrante")]
        public string Celebrante { get; set; }
        [DisplayName("Acta de Matrimonio")]
        public string ActaMatrimonio { get; set; }
    }
}