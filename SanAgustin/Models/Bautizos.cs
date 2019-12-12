using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class Bautizos
    {
        [Key]
        [DisplayName("Id Del Bautizo")]
        public int BautizoId { get; set; }
        [DisplayName("Nombre Del Bautizado")]
        public string Bautizado { get; set; }
        [DisplayName("Fecha del Bautizo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaBautizo { get; set; }
        [DisplayName("Lugar del Bautizo")]
        public string LugarBautizo { get; set; }
        [DisplayName("Padre Del Bautizado")]
        public string PadreBautizado { get; set; }
        [DisplayName("Cedula Del Padre")]
        public string CedPadre { get; set; }
        [DisplayName("Madre Del Bautizado")]
        public string MadreBautizado { get; set; }
        [DisplayName("Cedula De la Madre")]
        public string CedMadre { get; set; }
        [DisplayName("Padrino Del Bautizado")]
        public string PadrinoBautizado { get; set; }
        [DisplayName("Cedula Del Padrino")]
        public string CedPadrino { get; set; }
        [DisplayName("Nombre Del Representante")]
        public string Representante { get; set; }
        [DisplayName("Cedula del Representante")]
        public string CedRepresentante { get; set; }
        [DisplayName("Comentario, en caso de haber Representante")]
        public string Comentario { get; set; }
        [DisplayName("Bautizo Celebrado Por:")]
        public string Celebrante { get; set; }
    }
}