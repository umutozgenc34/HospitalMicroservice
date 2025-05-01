using AutoMapper;
using HospitalMicroservice.Doctor.Api.Features.Doctors.Create;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors;

public class DoctorMappingProfile : Profile
{
    public DoctorMappingProfile()
    {
        CreateMap<CreateDoctorCommand, Doctor>();
    }
}
