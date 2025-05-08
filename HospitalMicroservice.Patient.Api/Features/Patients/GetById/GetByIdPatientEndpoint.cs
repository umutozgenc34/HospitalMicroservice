using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.GetById;

public static class GetByIdPatientQueryEndpoint
{
    public static RouteGroupBuilder GetByIdPatientGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/{id:guid}", async (Guid id, IMediator mediator) => (await mediator.Send(new GetByIdPatientQuery(id))).ToGenericResult())
            .WithName("GetByIdPatient")
            .MapToApiVersion(1, 0);

        return group;
    }
}