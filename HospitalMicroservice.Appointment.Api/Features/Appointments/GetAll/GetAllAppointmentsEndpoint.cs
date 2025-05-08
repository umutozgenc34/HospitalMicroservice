using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAll;

public static class GetAllAppointmentsEndpoint
{
    public static RouteGroupBuilder GetAllAppointmentsGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/",
            async (IMediator mediator) =>
                (await mediator.Send(new GetAllAppointmentsQuery())).ToGenericResult())
            .WithName("GetAllAppointments")
            .MapToApiVersion(1, 0);

        return group;
    }
}