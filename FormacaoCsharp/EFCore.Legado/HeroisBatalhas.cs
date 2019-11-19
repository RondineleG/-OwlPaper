using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class HeroisBatalhas
    {
        public int HeroiId { get; set; }
        public int BatalhaId { get; set; }

        public virtual Batalhas Batalha { get; set; }
        public virtual Herois Heroi { get; set; }
    }
}
