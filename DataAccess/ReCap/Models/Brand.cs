using System.ComponentModel.DataAnnotations.Schema;
using Core;

namespace DataAccess.ReCap.Models
{
    public class Brand : IEntity
    {

        public int Id { get; set; }
        [Column("brand_name")]
        public string BrandName { get; set; }

    }
}
