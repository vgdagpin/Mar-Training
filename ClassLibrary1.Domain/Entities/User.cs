using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Domain.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int Age { get; set; }
        public Gender Gender { get; set; }
        public ICollection<LoginHistory> LoginHistories { get; private set; } = new HashSet<LoginHistory>();
    }
}
