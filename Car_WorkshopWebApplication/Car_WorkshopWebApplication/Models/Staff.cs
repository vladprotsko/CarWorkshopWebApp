using System.ComponentModel.DataAnnotations;

namespace Car_WorkshopWebApplication.Models
{
    public class Staff
    {
        public Staff() 
        {
            Services = new HashSet<Service>();
        }
        [Key]
        public int StaffId { get; set; }
        public int MobileStaff { get; set; }
        public string? Adress { get; set; }
        public string? StaffName { get; set; }
        public virtual ICollection<Service> Services { get; set; }

    }
}
