using Asp.Versioning.Builder;
using HospitalMicroservice.Patient.Api.Features.Patients.Create;
using HospitalMicroservice.Patient.Api.Features.Patients.Delete;
using HospitalMicroservice.Patient.Api.Features.Patients.GetAll;
using HospitalMicroservice.Patient.Api.Features.Patients.GetById;
using HospitalMicroservice.Patient.Api.Features.Patients.Update;

namespace HospitalMicroservice.Patient.Api.Features.Patients;

public static class PatientEndpointExtension
{
    public static void AddPatientGroupEndpointExtension(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/patients").WithTags("Patients")
            .CreatePatientGroupItemEndpoint()
            .GetAllPatientsGroupItemEndpoint()
            .DeletePatientGroupItemEndpoint()
            .GetByIdPatientGroupItemEndpoint()
            .UpdatePatientGroupItemEndpoint()
            .WithApiVersionSet(apiVersionSet);

    }
}