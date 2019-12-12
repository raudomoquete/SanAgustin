using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class Confirmacion
    {
        [Key]
        [DisplayName("Id")]
        public int ConfirmacionId { get; set; }
        [DisplayName("Nombre de Quien se Confirma")]
        public string Confirmado { get; set; }
        [DisplayName("Fecha de la Confirmacion")]
        public DateTime FechaConfirmacion { get; set; }
        [DisplayName("Lugar de la Confirmacion")]
        public string LugarConfirmacion { get; set; }
        [DisplayName("Nombre del Padre")]
        public string PadreConfirmado { get; set; }
        [DisplayName("Cedula del Padre")]
        public string CedPadre { get; set; }
        [DisplayName("Nombre de la Madre")]
        public string MadreConfirmado { get; set; }
        [DisplayName("Cedula de la Madre")]
        public string CedMadre { get; set; }
        [DisplayName("Nombre del Padrino")]
        public string PadrinoConfirmado { get; set; }
        [DisplayName("Cedula del Padrino")]
        public string CedPadrio { get; set; }
        [DisplayName("Nombre de la Madrina")]
        public string MadrinaConfirmado { get; set; }
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
        [DisplayName("Acta de Confirmacion")]
        public string ActaConfirmacion { get; set; }
    }
}