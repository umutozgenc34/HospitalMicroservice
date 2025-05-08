using HospitalMicroservice.Shared.Extensions;
using HospitalMicroservice.Shared.Filters;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.Create;

public static class CreateAppointmentEndpoint
{
    public static RouteGroupBuilder CreateAppointmentGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/",
            async (CreateAppointmentCommand request, IMediator mediator) =>
                (await mediator.Send(request)).ToGenericResult())
            .WithName("CreateAppointment")
            .MapToApiVersion(1,0)
            .AddEndpointFilter<ValidationFilter<CreateAppointmentCommand>>();

        return group;
    }
}