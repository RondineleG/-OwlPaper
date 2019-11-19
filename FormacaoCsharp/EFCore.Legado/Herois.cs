using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Herois
    {
        public Herois()
        {
            Armas = new HashSet<Armas>();
            HeroisBatalhas = new HashSet<HeroisBatalhas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual IdentidadesSecretas IdentidadesSecretas { get; set; }
        public virtual ICollection<Armas> Armas { get; set; }
        public virtual ICollection<HeroisBatalhas> HeroisBatalhas { get; set; }
    }
}
