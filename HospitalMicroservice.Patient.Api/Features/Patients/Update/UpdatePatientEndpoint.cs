using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Update;

public static class UpdatePatientEndpoint
{
    public static RouteGroupBuilder UpdatePatientGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPut("/", async (UpdatePatientCommand command, IMediator mediator) =>
        (await mediator.Send(command)).ToGenericResult())
        .WithName("UpdatePatient");

        return group;
    }
}