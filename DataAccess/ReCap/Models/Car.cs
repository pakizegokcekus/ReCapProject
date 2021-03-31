using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using Core;

namespace DataAccess.ReCap.Models
{
    public class Car : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Column("car_name")]
        public string CarName { get; set; }
        [Column("brand_id")]
        public int BrandId { get; set; }
        [Column("color_id")]
        public int ColorId { get; set; }
        [Column("model_year")]
        public DateTime ModelYear { get; set; }
        [Column("daily_price")]
        public double DailyPrice { get; set; }
        [Column("description")]
        public string Description { get; set; }

    }
}
