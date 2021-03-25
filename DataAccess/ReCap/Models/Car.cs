using System.ComponentModel.DataAnnotations.Schema;
using Core;

namespace DataAccess.ReCap.Models
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        [Column("car_name")]
        public string CarName { get; set; }
        [Column("brand_id")]
        public int BrandId { get; set; }
        [Column("color_id")]
        public int ColorId { get; set; }

    }
}
