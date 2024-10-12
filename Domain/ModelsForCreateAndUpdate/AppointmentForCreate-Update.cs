namespace Domain.ModelForCreate
{
    public class AppointmentForCreate_Update
    {
        public DateTime TheAppointment { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsBooked { get; set; } = false;
    }
}