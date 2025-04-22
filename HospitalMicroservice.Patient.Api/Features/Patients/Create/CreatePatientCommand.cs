using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Create;

public record CreatePatientCommand(string FirstName,string LastName,string IdentityNumber,DateTime BirthDate
    ,string Gender,string? PhoneNumber,string? Email,string? Address) : IRequest<ServiceResult<CreatePatientResponse>>;
