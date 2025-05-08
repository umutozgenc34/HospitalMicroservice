using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Delete;

public static class DeletePatientEndpoint
{
    public static RouteGroupBuilder DeletePatientGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapDelete("/{id:guid}", async (Guid id, IMediator mediator) =>
            (await mediator.Send(new DeletePatientCommand(id))).ToGenericResult())
            .WithName("DeletePatient")
            .MapToApiVersion(1, 0);
        return group;
    }
}