using Financeiro.Notificacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Financeiro.Entidades
{
    public class Base : Notifica
    {
        [Display(Name = "Código")]
        public int id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
