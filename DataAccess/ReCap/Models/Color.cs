using Core;

namespace DataAccess.ReCap.Models
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
