using HospitalMicroservice.Shared.Extensions;
using HospitalMicroservice.Shared.Filters;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Update;

public static class UpdatePatientEndpoint
{
    public static RouteGroupBuilder UpdatePatientGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPut("/", async (UpdatePatientCommand command, IMediator mediator) =>
        (await mediator.Send(command)).ToGenericResult())
        .WithName("UpdatePatient")
        .AddEndpointFilter<ValidationFilter<UpdatePatientCommand>>();

        return group;
    }
}