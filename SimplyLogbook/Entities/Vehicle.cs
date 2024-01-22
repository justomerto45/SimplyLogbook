using System.ComponentModel.DataAnnotations;

namespace SimplyLogbook.Entities
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        [Required]
        [StringLength(100)]
        public string Brand { get; set; }

        [Required]
        [StringLength(100)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string LicensePlate { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
