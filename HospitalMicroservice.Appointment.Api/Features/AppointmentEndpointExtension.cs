using HospitalMicroservice.Appointment.Api.Features.Appointments.Create;
using HospitalMicroservice.Appointment.Api.Features.Appointments.GetAll;

namespace HospitalMicroservice.Appointment.Api.Features;

public static class AppointmentEndpointExtension
{
    public static void AddAppointmentGroupEndpointExtensions(this WebApplication app)
    {
        app.MapGroup("api/appointments").WithTags("Appointments")
            .CreateAppointmentGroupItemEndpoint()
            .GetAllAppointmentsGroupItemEndpoint();

    }
}

