using Asp.Versioning.Builder;
using HospitalMicroservice.Doctor.Api.Features.Doctors.Create;
using HospitalMicroservice.Doctor.Api.Features.Doctors.Delete;
using HospitalMicroservice.Doctor.Api.Features.Doctors.GetAll;
using HospitalMicroservice.Doctor.Api.Features.Doctors.GetById;
using HospitalMicroservice.Doctor.Api.Features.Doctors.Update;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors;

public static class DoctorEndpointExtension
{
    public static void AddDoctorGroupEndpointExtensions(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/doctors").WithTags("Doctors")
            .CreateDoctorGroupItemEndpoint()
            .DeleteDoctorGroupItemEndpoint()
            .GetAllDoctorsGroupItemEndpoint()
            .UpdateDoctorGroupItemEndpoint()
            .GetByIdDoctorGroupItemEndpoint()
            .WithApiVersionSet(apiVersionSet);
                        
    }
}
