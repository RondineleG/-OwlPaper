using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Categoria
    {
        public Categoria()
        {
            Produto = new HashSet<Produto>();
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
