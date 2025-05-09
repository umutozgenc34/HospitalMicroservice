using HospitalMicroservice.Shared.Extensions;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.GetAppointmentsByPatientId;

public  static class GetAppointmentsByPatientIdEndpoint
{
    public static RouteGroupBuilder GetAppointmentsByPatientIdGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/by-patient/{patientId:guid}",
            async (Guid patientId, IMediator mediator) =>
                (await mediator.Send(new GetAppointmentsByPatientIdQuery(patientId))).ToGenericResult())
            .WithName("GetAppointmentsByPatientId")
            .MapToApiVersion(1, 0);

        return group;
    }
}
