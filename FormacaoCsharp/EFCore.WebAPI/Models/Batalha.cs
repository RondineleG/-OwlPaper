using System;

namespace EFCore.WebAPI.Models
{
    public class Batalha
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataFim { get; set; }
    }
}
