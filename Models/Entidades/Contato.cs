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

        [Display(Description = "Lista de telefone")]
        public string ListaTelefone { get; set; }

        [Display(Description = "Lista de endereco")]
        public string ListaEndereco { get; set; }

        public string Tipo { get; set; }


    }
}
