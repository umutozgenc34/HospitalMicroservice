using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Create;

public static class CreateDoctorEndpoint
{
    public static RouteGroupBuilder CreateDoctorGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/",
            async (CreateDoctorCommand request, IMediator mediator) =>
                            (await mediator.Send(request)).ToGenericResult())
                             .WithName("CreateDoctor");

        return group;
    }
}
