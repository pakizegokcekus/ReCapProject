using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Models
{
    public class Customer
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("company_name")]
        public string CompanyName { get; set; }
    }
}
