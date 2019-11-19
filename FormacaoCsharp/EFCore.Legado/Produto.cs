using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int Categoria { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public string Descricao { get; set; }
        public int? Porcetagen { get; set; }
        public int? Quantidade { get; set; }
        public int? QuantidadeMinima { get; set; }
        public int? QuantidadeMaxima { get; set; }
        public int TipoCadastro { get; set; }
        public bool? GerenciarEstoque { get; set; }

        public virtual Categoria CategoriaNavigation { get; set; }
        public virtual TipoCadastro TipoCadastroNavigation { get; set; }
    }
}
