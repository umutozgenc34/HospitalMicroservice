using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Create;

public record CreateDoctorCommand(string FirstName,string LastName,string Specialization,string Gender)
    : IRequest<ServiceResult<CreateDoctorResponse>>;

