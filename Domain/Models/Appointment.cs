namespace Domain.Models
{
    //مواعيد
    public class Appointment
    {
        public Appointment()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public DateTime TheAppointment { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsBooked { get; set; } = false;
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public Guid? ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}