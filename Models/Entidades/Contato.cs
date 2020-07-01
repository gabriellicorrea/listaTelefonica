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
        public int Nome { get; set; }

        [Display(Description = "Email")]
        public int Email { get; set; }

        [Display(Description = "CPF")]
        public int CPF { get; set; }

        [Display(Description = "Lista de telefone")]
        public int ListaTelefone { get; set; }

        [Display(Description = "Lista de endereco")]
        public int ListaEndereco { get; set; }

    }
}
