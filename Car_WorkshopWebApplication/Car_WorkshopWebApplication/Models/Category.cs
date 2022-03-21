using System.ComponentModel.DataAnnotations;

namespace Car_WorkshopWebApplication.Models
{
    public class Category
    {
        public Category()
        {
            Services = new HashSet<Service>();
        }
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Категорія роботи")]
        public string? WorkName { get; set; }
        [Display(Name = "Опис роботи")]
        public string? Description { get; set; }
        [Display(Name = "Ціна")]
        public int? price { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
