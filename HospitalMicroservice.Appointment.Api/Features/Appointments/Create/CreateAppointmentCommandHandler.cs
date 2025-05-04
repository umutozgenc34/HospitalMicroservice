using AutoMapper;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.Create;

public class CreateAppointmentCommandHandler(AppDbContext context, IMapper mapper)
    : IRequestHandler<CreateAppointmentCommand, ServiceResult<CreateAppointmentResponse>>
{
    public async Task<ServiceResult<CreateAppointmentResponse>> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
    {
        var existAppointment = await context.Appointments
           .AnyAsync(x => x.DoctorId == request.DoctorId &&
                          x.AppointmentDate == request.AppointmentDate,
                     cancellationToken);

        if (existAppointment)
        {
            return ServiceResult<CreateAppointmentResponse>.Error(
                "Appointment already exists",
                $"There is already an appointment with this doctor at the specified time.",
                HttpStatusCode.BadRequest);
        }

        var appointment = mapper.Map<Appointment>(request);
        appointment.Id = NewId.NextSequentialGuid();

        await context.Appointments.AddAsync(appointment, cancellationToken);

        await context.SaveChangesAsync(cancellationToken);

        return ServiceResult<CreateAppointmentResponse>.SuccessAsCreated(
            new CreateAppointmentResponse(appointment.Id),
            $"/api/appointments/{appointment.Id}");
    }
}
