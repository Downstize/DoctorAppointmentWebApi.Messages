namespace DoctorAppointmentWebApi.Messages;

public class AppointmentMessage
{
    public Guid AppointmentId { get; set; }
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public string Status { get; set; }
    public string PatientFullName { get; set; }
}