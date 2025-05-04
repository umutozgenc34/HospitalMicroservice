using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.Create;

public record CreateAppointmentCommand(Guid DoctorId,Guid PatientId,DateTime AppointmentDate) :
    IRequest<ServiceResult<CreateAppointmentResponse>>;

