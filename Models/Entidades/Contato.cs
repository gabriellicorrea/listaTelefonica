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
        public string Nome { get; set; }

        [Display(Description = "Email")]
        public string Email { get; set; }

        [Display(Description = "CPF")]
        public string CPF { get; set; }

        [Display(Description = "Lista de telefone")]
        public string ListaTelefone { get; set; }

        [Display(Description = "Lista de endereco")]
        public string ListaEndereco { get; set; }

    }
}
