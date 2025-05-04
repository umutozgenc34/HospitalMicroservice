using HospitalMicroservice.Doctor.Api.Repositories;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments;

public class Appointment : BaseEntity
{
    public Guid DoctorId { get; set; }
    public Guid PatientId { get; set; }
    public DateTime AppointmentDate { get; set; }
}
