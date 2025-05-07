using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAppointmentsByDoctorId;

public class GetAppointmentsByDoctorIdQueryHandler(AppDbContext context) : IRequestHandler<GetAppointmentsByDoctorIdQuery, ServiceResult<List<AppointmentDto>>>
{
    public async Task<ServiceResult<List<AppointmentDto>>> Handle(GetAppointmentsByDoctorIdQuery request, CancellationToken cancellationToken)
    {
        var appointments = await context.Appointments
            .Where(x => x.DoctorId == request.DoctorId)
            .Select(x => new AppointmentDto(
                x.Id,
                x.DoctorId,
                x.PatientId,
                x.AppointmentDate))
            .ToListAsync(cancellationToken);

        return ServiceResult<List<AppointmentDto>>.SuccessAsOk(appointments);
    }
}

