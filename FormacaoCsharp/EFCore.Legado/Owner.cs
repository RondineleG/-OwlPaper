using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Owner
    {
        public Owner()
        {
            Account = new HashSet<Account>();
        }

        public string OwnerId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Account> Account { get; set; }
    }
}
