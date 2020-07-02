using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTelefonica.Models.Entidades
{
    [Table("Grupo")]
    public class Grupo
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
