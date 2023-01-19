using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaControle.Models
{
    public class GruposDetalhes
    {
        [Key]
        public int GruposDetalhesId { get; set; }

        public int GrupoId { get; set; }

        public int UserId { get; set; }


        [JsonIgnore]
        public virtual Grupos Grupos { get; set; }


        [JsonIgnore]
        public virtual Usuario Estudante { get; set; }

        public string GrupoEstudante { get { return string.Format("{0} / {1}", Grupos.Descricao, Estudante.NomeCompleto); } }

       // public virtual ICollection<Notas> Notas { get; set; }


    }
}