using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class IdentidadesSecretas
    {
        public int Id { get; set; }
        public string NomeReal { get; set; }
        public int HeroiId { get; set; }

        public virtual Herois Heroi { get; set; }
    }
}
