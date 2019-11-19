using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Alunos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public int? Ra { get; set; }
    }
}
