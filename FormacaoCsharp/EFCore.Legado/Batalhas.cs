using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Batalhas
    {
        public Batalhas()
        {
            HeroisBatalhas = new HashSet<HeroisBatalhas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataInicio { get; set; }

        public virtual ICollection<HeroisBatalhas> HeroisBatalhas { get; set; }
    }
}
