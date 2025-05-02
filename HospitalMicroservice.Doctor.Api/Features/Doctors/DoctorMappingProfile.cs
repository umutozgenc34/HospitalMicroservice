using AutoMapper;
using HospitalMicroservice.Doctor.Api.Features.Doctors.Create;
using HospitalMicroservice.Doctor.Api.Features.Doctors.Update;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors;

public class DoctorMappingProfile : Profile
{
    public DoctorMappingProfile()
    {
        CreateMap<CreateDoctorCommand, Doctor>();
        CreateMap<Doctor, DoctorDto>().ReverseMap();
        CreateMap<UpdateDoctorCommand, Doctor>();
    }
}
