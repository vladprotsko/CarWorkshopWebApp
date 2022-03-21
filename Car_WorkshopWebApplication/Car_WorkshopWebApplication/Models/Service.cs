using System.ComponentModel.DataAnnotations;

namespace Car_WorkshopWebApplication.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public int? Car { get; set; }
        public string? WorkCategory { get; set; }
        public DateTime? FinishDate { get; set; }
        public string? Staffs { get; set; }
        
        public virtual Cars? CarNavigation { get; set; }
        public virtual Category? WorkCategoryNavigation { get; set; }
        public virtual Staff? StaffsNavigation { get; set; }
    }
}
