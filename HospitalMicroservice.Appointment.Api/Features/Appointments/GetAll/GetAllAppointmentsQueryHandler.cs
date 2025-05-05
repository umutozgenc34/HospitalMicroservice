using AutoMapper;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAll;

public class GetAllAppointmentsQueryHandler(AppDbContext context, IMapper mapper)
    : IRequestHandler<GetAllAppointmentsQuery, ServiceResult<List<AppointmentDto>>>
{
    public async Task<ServiceResult<List<AppointmentDto>>> Handle(GetAllAppointmentsQuery request, CancellationToken cancellationToken)
    {
        var appointments = await context.Appointments.AsNoTracking().ToListAsync(cancellationToken);

        var result = mapper.Map<List<AppointmentDto>>(appointments);

        return ServiceResult<List<AppointmentDto>>.SuccessAsOk(result);
    }
}