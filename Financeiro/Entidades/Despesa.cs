using Financeiro.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Financeiro.Entidades
{
    [Table("Despesa")]
    public class Despesa : Base
    {
        public decimal valor  { get; set; }

        public int Mes { get; set; }
        public int Ano { get; set; }

        public EnumTipoDespesa TipoDespesa { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }

        public bool Pago { get; set; }
        public bool DespesaAtrasada { get; set; }

        [ForeignKey("Categoria")]
        [Column(Order = 1)]

        public int IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
