namespace DoctorAppointmentWebApi.Messages;

public class ToPatientAboutUpdatedDoctorSchedule
{
    public string PatientFirstName { get; set; }
    public string PatientLastName { get; set; }
    public string DoctorFirstName { get; set; }
    public string DoctorLastName { get; set; }
    public TimeSpan AvailableFrom { get; set; }
    public TimeSpan AvailableTo { get; set; }
    public string DayOfWeek { get; set; }
}