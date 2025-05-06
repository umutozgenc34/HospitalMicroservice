using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.Delete;

public static class DeleteAppointmentEndpoint
{
    public static RouteGroupBuilder DeleteAppointmentGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapDelete("/{id:guid}",
            async (Guid id, IMediator mediator) =>
                (await mediator.Send(new DeleteAppointmentCommand(id))).ToGenericResult())
            .WithName("DeleteAppointment");

        return group;
    }
}