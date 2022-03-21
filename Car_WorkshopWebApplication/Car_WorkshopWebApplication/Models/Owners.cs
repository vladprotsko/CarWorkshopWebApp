using System.ComponentModel.DataAnnotations;

namespace Car_WorkshopWebApplication.Models
{
    public class Owners
    {
        public Owners()
        {
            Cars = new HashSet<Cars>();
        }
        [Key]
        public int OwnerId { get; set; }
        public string? OwnerName { get; set; }
        public int? MobileOwner { get; set; }
        public int? LicenseNum { get; set; }
        public virtual ICollection<Cars> Cars { get; set; }
    }
}
