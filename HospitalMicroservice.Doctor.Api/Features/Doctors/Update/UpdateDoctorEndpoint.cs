using HospitalMicroservice.Shared.Extensions;
using HospitalMicroservice.Shared.Filters;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Update;

public static class UpdateDoctorEndpoint
{
    public static RouteGroupBuilder UpdateDoctorGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPut("/", async (UpdateDoctorCommand command, IMediator mediator) =>
        (await mediator.Send(command)).ToGenericResult())
        .WithName("UpdateDoctor")
        .MapToApiVersion(1, 0)
        .AddEndpointFilter<ValidationFilter<UpdateDoctorCommand>>();

        return group;
    }
}
