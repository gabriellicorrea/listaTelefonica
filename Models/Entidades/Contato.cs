using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTelefonica.Models.Entidades
{
    [Table("Contato")]
    public class Contato
    {
        [Display(Description = "Codigo")]

        public int Id { get; set; }
        [Display(Description = "Nome do usuario")]
        [StringLength(100)]
        [Required(ErrorMessage = "Nome obrigatorio.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite um Email valido.")]
        [Display(Description = "Email")]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Digite um CPF valido.")]
        [Display(Description = "CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Escolha o tipo de telefone")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Informe o DDD")]
        public string DDD { get; set; }


        [Required(ErrorMessage = "Informe o numero ")]
        public string Numero { get; set; }


        public string Ramal { get; set; }

        [Required]
        public string NomeReferência { get; set; }

        [Required(ErrorMessage = "Informe o logradouro")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Informe o bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe a cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe o cep")]
        public string CEP { get; set; }
    }
}