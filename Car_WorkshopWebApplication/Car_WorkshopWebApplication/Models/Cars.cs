using System.ComponentModel.DataAnnotations;

namespace Car_WorkshopWebApplication.Models
{
    public class Cars
    {
        public Cars() 
        {
            Services = new HashSet<Service>();
        }
        [Key]
        public int CarId { get; set; }
        public int? Owner { get; set; }
        public string? CarBrand { get; set; }
        public string? LicensePlate { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual Owners OwnerNavigation { get; set; }
    }
}
