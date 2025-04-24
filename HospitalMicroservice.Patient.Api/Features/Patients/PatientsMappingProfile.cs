using AutoMapper;

namespace HospitalMicroservice.Patient.Api.Features.Patients;

public class PatientsMappingProfile : Profile
{
    public PatientsMappingProfile()
    {
        CreateMap<Patient, PatientDto>().ReverseMap();
    }
}
