using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.GetAll;

public static class GetAllDoctorsEndpoint
{
    public static RouteGroupBuilder GetAllDoctorsGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/", async (IMediator mediator) => (await mediator.Send(new GetAllDoctorsQuery())).ToGenericResult())
            .WithName("GetAllDoctors");

        return group;
    }
}
