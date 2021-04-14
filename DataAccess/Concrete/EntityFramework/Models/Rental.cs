using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Models
{
    public class Rental
    {

        public int Id { get; set; }
        [Column("car_id")]
        public int CarId { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("rent_time")]
        public DateTime RentDateTime { get; set; }
        [Column("return_time")]
        public DateTime ReturnDate { get; set; }
    }
}
