using HospitalMicroservice.Appointment.Api.Features.Appointments.GetAppointmentsByDoctorId;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAppointmentsByPatientId;

public class GetAppointmentsByPatientIdQueryHandler(AppDbContext context) : IRequestHandler<GetAppointmentsByPatientIdQuery, ServiceResult<List<AppointmentDto>>>
{
    public async Task<ServiceResult<List<AppointmentDto>>> Handle(GetAppointmentsByPatientIdQuery request, CancellationToken cancellationToken)
    {
        var appointments = await context.Appointments
            .Where(x => x.PatientId == request.PatientId)
            .Select(x => new AppointmentDto(
                x.Id,
                x.DoctorId,
                x.PatientId,
                x.AppointmentDate))
            .ToListAsync(cancellationToken);

        return ServiceResult<List<AppointmentDto>>.SuccessAsOk(appointments);
    }
}
