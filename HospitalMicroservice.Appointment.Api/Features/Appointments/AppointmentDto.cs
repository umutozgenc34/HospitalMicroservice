namespace HospitalMicroservice.Appointment.Api.Features.Appointments;

public record AppointmentDto(Guid Id,Guid DoctorId,Guid PatientId, DateTime AppointmentDate);

