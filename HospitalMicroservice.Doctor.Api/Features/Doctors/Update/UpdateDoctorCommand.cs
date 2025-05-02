using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Update;

public record UpdateDoctorCommand(Guid Id,string FirstName,string LastName,string Specialization, string Gender) : IRequest<ServiceResult>;

