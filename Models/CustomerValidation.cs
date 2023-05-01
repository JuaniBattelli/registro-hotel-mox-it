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
                    return new ValidationResult("El Check-in debe ser previo al Check-Out. Revise las fechas por favor.");
                }
            }

            if (customer.CheckInDate.HasValue && customer.CheckInDate.Value < DateTime.Now.Date)
            {
                return new ValidationResult("El Check-In debe ser una fecha válida. Desde hoy en adelante.");
            }

            if (customer.Room.HasValue && IsRoomAlreadyUsed(customer.Room.Value))
            {
                return new ValidationResult("La habitación ya ha sido utilizada en una reserva anterior.");
            }



            return ValidationResult.Success;
        }

        private bool IsRoomAlreadyUsed(int roomNumber)
        {
            //TO-DO Realizar validacion
            throw new NotImplementedException();
        }
    }
}


