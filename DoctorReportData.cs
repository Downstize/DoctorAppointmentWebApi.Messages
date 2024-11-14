namespace DoctorAppointmentWebApi.Messages;

public class DoctorReportData
{
    public string DoctorName { get; set; }
    public string Specialization { get; set; }
    public string Period { get; set; }
    public int TotalPatients { get; set; }
    public List<PatientInfo> PatientDetails { get; set; }
}
