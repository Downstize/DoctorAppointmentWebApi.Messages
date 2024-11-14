namespace DoctorAppointmentWebApi.Messages;

public class DoctorScheduleUpdatedMessage
{
    public TimeSpan AvailableFrom { get; set; }
    public TimeSpan AvailableTo { get; set; }
    public string DayOfWeek { get; set; }
    public string DoctorName { get; set; }
    public string DoctorLastName { get; set; }
}
