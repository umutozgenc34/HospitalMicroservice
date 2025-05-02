using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.GetById;

public static class GetDoctorByIdEndpoint
{
    public static RouteGroupBuilder GetByIdDoctorGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/{id:guid}", async (Guid id, IMediator mediator) => (await mediator.Send(new GetDoctorByIdQuery(id))).ToGenericResult())
            .WithName("GetByIdDoctor");

        return group;
    }
}
