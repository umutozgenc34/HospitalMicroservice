using AutoMapper;
using HospitalMicroservice.Patient.Api.Features.Patients.Update;

namespace HospitalMicroservice.Patient.Api.Features.Patients;

public class PatientsMappingProfile : Profile
{
    public PatientsMappingProfile()
    {
        CreateMap<Patient, PatientDto>().ReverseMap();
        CreateMap<UpdatePatientCommand, Patient>();
    }
}
