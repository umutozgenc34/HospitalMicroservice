﻿using HospitalMicroservice.Shared.Extensions;
using HospitalMicroservice.Shared.Filters;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Create;

public static class CreateDoctorEndpoint
{
    public static RouteGroupBuilder CreateDoctorGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/",
            async (CreateDoctorCommand request, IMediator mediator) =>
                            (await mediator.Send(request)).ToGenericResult())
                             .WithName("CreateDoctor")
                             .MapToApiVersion(1, 0)
                             .AddEndpointFilter<ValidationFilter<CreateDoctorCommand>>();

        return group;
    }
}
