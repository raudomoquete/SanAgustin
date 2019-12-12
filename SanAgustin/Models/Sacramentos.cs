using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanAgustin.Models
{
    public class Sacramentos
    {
        [Key]
        [DisplayName("Id Del Sacramento")]
        public int SacramentoId { get; set; }
        [DisplayName("Tipo De Sacramento")]
        public string TipoSacramento { get; set; }
    }
}