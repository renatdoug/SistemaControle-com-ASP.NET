using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaControle.Models
{
    public class Notas
    {
        [Key]
        public int NotaId { get; set; }

        public int GruposDetalhesId { get; set; }

        [Required(ErrorMessage = "Digite o campo {0}")]
        [Range(0, 1, ErrorMessage = "O campo {0} tem que está {1} e {2}")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public float Percentual { get; set; }

        [Required(ErrorMessage = "Digite o campo {0}")]
        [Range(0, 5, ErrorMessage = "O campo {0} contém valores entre {1} and {2}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Nota { get; set; }

        public virtual GruposDetalhes GruposDetalhes { get; set; }

    }
}