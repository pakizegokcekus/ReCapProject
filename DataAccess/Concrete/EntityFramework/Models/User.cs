using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Models
{
    public class User
    {
        public int Id { get; set; }
        [Column("firstname")]
        public string FirstName { get; set; }
        [Column("lastname")]
        public string LastName { get; set; }
        [Column("email")]
        public string EMail { get; set; }
        [Column("password")]
        public string Password { get; set; }
    }
}
