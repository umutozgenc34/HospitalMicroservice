using HospitalMicroservice.Doctor.Api.Features.Doctors.Create;
using HospitalMicroservice.Doctor.Api.Features.Doctors.Delete;
using HospitalMicroservice.Doctor.Api.Features.Doctors.GetAll;
using HospitalMicroservice.Doctor.Api.Features.Doctors.GetById;
using HospitalMicroservice.Doctor.Api.Features.Doctors.Update;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors;

public static class DoctorEndpointExtension
{
    public static void AddDoctorGroupEndpointExtensions(this WebApplication app)
    {
        app.MapGroup("api/doctors").WithTags("Doctors")
            .CreateDoctorGroupItemEndpoint()
            .DeleteDoctorGroupItemEndpoint()
            .GetAllDoctorsGroupItemEndpoint()
            .UpdateDoctorGroupItemEndpoint()
            .GetByIdDoctorGroupItemEndpoint();
                        
    }
}
