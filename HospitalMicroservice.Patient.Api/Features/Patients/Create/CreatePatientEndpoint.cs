using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Create;

public static class CreatePatientEndpoint
{
    public static RouteGroupBuilder CreatePatientGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/",
                async (CreatePatientCommand command, IMediator mediator) =>
                    (await mediator.Send(command)).ToGenericResult())
            .WithName("CreatePatient");

        return group;
    }
}