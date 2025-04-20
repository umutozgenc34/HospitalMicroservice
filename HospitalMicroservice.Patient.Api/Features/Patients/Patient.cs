using HospitalMicroservice.Patient.Api.Repositories;
using MongoDB.Bson.Serialization.Attributes;

namespace HospitalMicroservice.Patient.Api.Features.Patients;

public class Patient : BaseEntity
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string IdentityNumber { get; set; } = default!;
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; } = default!;
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public DateTime Created { get; set; } 
}