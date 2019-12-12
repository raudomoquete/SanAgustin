using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class PrimeraComunion
    {
        [Key]
        [DisplayName("Id")]
        public int ComunionId { get; set; }
        [DisplayName("Quien Recibe La Comunion")]
        public string RecComunion { get; set; }
        [DisplayName("Fecha de la Celebracion")]
        public DateTime FechaComunion { get; set; }
        [DisplayName("Lugar de la Comunion")]
        public string LugarComunion { get; set; }
        [DisplayName("Nombre del Padre")]
        public string PadreComunion { get; set; }
        [DisplayName("Cedula del Padre")]
        public string CedPadre { get; set; }
        [DisplayName("Nombre de la Madre")]
        public string MadreComunion { get; set; }
        [DisplayName("Cedula de la Madre")]
        public string CedMadre { get; set; }
        [DisplayName("Padrino")]
        public string PadrinoComunion { get; set; }
        [DisplayName("Cedula del Padrino")]
        public string CedPadrino { get; set; }
        [DisplayName("Madrina")]
        public string MadrinaComunion { get; set; }
        [DisplayName("Cedula de la Madrina")]
        public string CedMadrina { get; set; }
        [DisplayName("Representante")]
        public string Representante { get; set; }
        [DisplayName("Cedula del Representante")]
        public string CedRepresentante { get; set; }
        [DisplayName("Comentario")]
        public string Comentario { get; set; }
        [DisplayName("Celebrante")]
        public string Celebrante { get; set; }
        [DisplayName("Acta de la Primera Comunion")]
        public string ActaComunion { get; set; }
    }
}