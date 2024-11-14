namespace DoctorAppointmentWebApi.Messages;

public class AppointmentMessage
{
    public Guid AppointmentId { get; set; }
    public string PatientId { get; set; }
    public string DoctorId { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public string Status { get; set; }
    public string Notes { get; set; }
}
