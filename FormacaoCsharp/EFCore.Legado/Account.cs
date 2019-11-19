using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Account
    {
        public string AccountId { get; set; }
        public DateTime DateCreated { get; set; }
        public string AccountType { get; set; }
        public string OwnerId { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
