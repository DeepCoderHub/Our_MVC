using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OurWeb.Models
{
    public class Category
    {
        [Key]
        public int Id  { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Oreder")]
        [Range(1,100,ErrorMessage ="Display Oredr must be between 1-100")]
        public int DisplayOrder { get; set; }

    }
}
