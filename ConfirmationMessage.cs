namespace DoctorAppointmentWebApi.Messages;

public class ConfirmationMessage
{
    public Guid AppointmentId { get; set; }
    public string ConfirmationCode { get; set; }
}