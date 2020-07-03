using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTelefonica.Models.Entidades
{
    public class Telefones
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("ContatoId")]
        public int ContatoId { get; set; }
        public virtual Contato Contato { get; set; }

        [Required(ErrorMessage = "Escolha o tipo de telefone")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Informe o DDD")]
        public string DDD { get; set; }


        [Required(ErrorMessage = "Informe o numero ")]
        public string Numero { get; set; }

        public string Ramal { get; set; }

    }
}
