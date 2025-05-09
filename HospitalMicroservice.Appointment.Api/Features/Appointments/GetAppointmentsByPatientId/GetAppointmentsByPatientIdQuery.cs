using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAppointmentsByPatientId;

public record GetAppointmentsByPatientIdQuery(Guid PatientId) : IRequest<ServiceResult<List<AppointmentDto>>>;
