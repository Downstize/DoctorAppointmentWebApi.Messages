namespace DoctorAppointmentWebApi.Messages;

public class PatientInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Symptoms { get; set; }
}

