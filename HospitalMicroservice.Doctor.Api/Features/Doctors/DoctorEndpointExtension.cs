using HospitalMicroservice.Doctor.Api.Features.Doctors.Create;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors;

public static class DoctorEndpointExtension
{
    public static void AddDoctorGroupEndpointExtensions(this WebApplication app)
    {
        app.MapGroup("api/doctors").WithTags("Doctors")
            .CreateDoctorGroupItemEndpoint();
                        
    }
}
