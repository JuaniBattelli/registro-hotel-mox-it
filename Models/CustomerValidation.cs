using System.ComponentModel.DataAnnotations;

namespace registro_hotel_mox_it.Models
{
    public class CustomerValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.CheckInDate.HasValue && customer.CheckOutDate.HasValue)
            {
                if (customer.CheckInDate.Value > customer.CheckOutDate.Value)
                {
                    return new ValidationResult("Check-in must be prior to Check-Out. Check dates please.");
                }
            }

            if (customer.CheckInDate.HasValue && customer.CheckInDate.Value < DateTime.Now.Date)
            {
                return new ValidationResult("Check-in date must be valid. From now on.");
            }
            return ValidationResult.Success;
        }

    }
}


