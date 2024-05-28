using System.ComponentModel.DataAnnotations;

namespace EticProje.Models
{
    public class Category
    {
        [Key]public int CategoryId { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string? CategoyName { get; set; }
        virtual public List<Products>? Products { get; set; }
    }
}
