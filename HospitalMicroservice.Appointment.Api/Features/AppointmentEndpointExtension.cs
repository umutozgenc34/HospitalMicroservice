using Asp.Versioning.Builder;
using HospitalMicroservice.Appointment.Api.Features.Appointments.Create;
using HospitalMicroservice.Appointment.Api.Features.Appointments.Delete;
using HospitalMicroservice.Appointment.Api.Features.Appointments.GetAll;
using HospitalMicroservice.Appointment.Api.Features.Appointments.GetAppointmentsByDoctorId;

namespace HospitalMicroservice.Appointment.Api.Features;

public static class AppointmentEndpointExtension
{
    public static void AddAppointmentGroupEndpointExtensions(this WebApplication app , ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/appointments").WithTags("Appointments")
            .CreateAppointmentGroupItemEndpoint()
            .GetAllAppointmentsGroupItemEndpoint()
            .DeleteAppointmentGroupItemEndpoint()
            .GetAppointmentsByDoctorIdGroupItemEndpoint()
            .WithApiVersionSet(apiVersionSet);

    }
}

