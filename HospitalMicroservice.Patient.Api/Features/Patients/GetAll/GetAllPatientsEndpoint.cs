using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.GetAll;

public static class GetAllPatientsEndpoint
{
    public static RouteGroupBuilder GetAllPatientsGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/", async (IMediator mediator) => (await mediator.Send(new GetAllPatientsQuery())).ToGenericResult())
            .WithName("GetAllPatients");

        return group;
    }
}