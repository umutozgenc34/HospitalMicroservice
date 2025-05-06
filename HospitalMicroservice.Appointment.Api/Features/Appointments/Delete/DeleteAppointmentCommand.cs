using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.Delete;

public record DeleteAppointmentCommand(Guid Id) : IRequest<ServiceResult>;
