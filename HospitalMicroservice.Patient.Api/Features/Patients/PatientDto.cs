namespace HospitalMicroservice.Patient.Api.Features.Patients;

public sealed record PatientDto 
{
    public Guid Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string IdentityNumber { get; init; } 
    public DateTime BirthDate { get; init; }
    public string Gender { get; init; } 
    public string? PhoneNumber { get; init; }
    public string? Email { get; init; }
    public string? Address { get; init; }
    public DateTime Created { get; init; }
}