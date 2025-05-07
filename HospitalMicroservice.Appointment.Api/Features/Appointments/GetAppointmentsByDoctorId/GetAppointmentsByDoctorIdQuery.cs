using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAppointmentsByDoctorId;

public record GetAppointmentsByDoctorIdQuery(Guid DoctorId) : IRequest<ServiceResult<List<AppointmentDto>>>;

