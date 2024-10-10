namespace Domain.ModelForCreate
{
    public class ReservationForCreate_Update
    {
        public bool IsDeleted { get; set; } = false;
        public Guid UserId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid AppointmentId { get; set; }
    }
}