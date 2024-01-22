using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SimplyLogbook.Data;

namespace SimplyLogbook.Entities
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        [StringLength(500)]
        public string Route { get; set; }

        [Required]
        [StringLength(500)]
        public string Purpose { get; set; }

        [Required]
        public double StartMileage { get; set; }

        [Required]
        public double EndMileage { get; set; }

        public int OdometerReadingAtDeparture { get; set; }
        public int OdometerReadingAtArrival { get; set; }

        [Required]

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } // Beziehung zum Firmen-PKW

        // für die berechnung der distanz braucht man den km stand vor abfahrt und am ankunft
        public decimal GetDistance() => Math.Round(Convert.ToDecimal(OdometerReadingAtArrival - OdometerReadingAtDeparture), 2);
        public double GetTripDurationMinutes() => (EndTime - StartTime).TotalMinutes;
    }
}
