using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAppointmentsByDoctorId;

public static class GetAppointmentsByDoctorIdEndpoint
{
    public static RouteGroupBuilder GetAppointmentsByDoctorIdGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/by-doctor/{doctorId:guid}",
            async (Guid doctorId, IMediator mediator) =>
                (await mediator.Send(new GetAppointmentsByDoctorIdQuery(doctorId))).ToGenericResult())
            .WithName("GetAppointmentsByDoctorId");

        return group;
    }
}