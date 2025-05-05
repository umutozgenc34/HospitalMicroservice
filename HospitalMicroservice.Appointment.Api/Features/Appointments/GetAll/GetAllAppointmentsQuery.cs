using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAll;

public record GetAllAppointmentsQuery() : IRequest<ServiceResult<List<AppointmentDto>>>;


