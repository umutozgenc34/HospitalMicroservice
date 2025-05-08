using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Delete;

public static class DeleteDoctorEndpoint
{
    public static RouteGroupBuilder DeleteDoctorGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapDelete("/{id:guid}", async (Guid id, IMediator mediator) =>
            (await mediator.Send(new DeleteDoctorCommand(id))).ToGenericResult())
            .WithName("DeleteDoctor")
            .MapToApiVersion(1, 0);
        return group;
    }
}
