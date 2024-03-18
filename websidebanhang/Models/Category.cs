using System.ComponentModel.DataAnnotations;

namespace websidebanhang.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
