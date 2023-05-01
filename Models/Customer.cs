using System.ComponentModel.DataAnnotations;

namespace registro_hotel_mox_it.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? Room { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? CheckInDate { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? CheckOutDate { get; set; }
    }
}
