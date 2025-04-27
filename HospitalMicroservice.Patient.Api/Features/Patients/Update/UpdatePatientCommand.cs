using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Update;

public record UpdatePatientCommand(Guid Id,
    string FirstName,
    string LastName,
    string IdentityNumber,
    DateTime BirthDate,
    string Gender, 
    string? PhoneNumber,
    string? Email,
    string? Address) : IRequest<ServiceResult>;

