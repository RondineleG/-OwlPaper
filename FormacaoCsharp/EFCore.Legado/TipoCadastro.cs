using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class TipoCadastro
    {
        public TipoCadastro()
        {
            Produto = new HashSet<Produto>();
        }

        public int TipoCadastroId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
