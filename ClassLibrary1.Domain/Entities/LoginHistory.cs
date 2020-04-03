using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Domain.Entities
{
    public class LoginHistory
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime LoginDate { get; set; }
        public User User { get; set; }
    }
}
