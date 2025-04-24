using HospitalMicroservice.Patient.Api.Features.Patients.Create;
using HospitalMicroservice.Patient.Api.Features.Patients.GetAll;

namespace HospitalMicroservice.Patient.Api.Features.Patients;

public static class PatientEndpointExtension
{
    public static void AddPatientGroupEndpointExtension(this WebApplication app)
    {
        app.MapGroup("api/patients").WithTags("Patients")
            .CreatePatientGroupItemEndpoint()
            .GetAllPatientsGroupItemEndpoint();

    }
}