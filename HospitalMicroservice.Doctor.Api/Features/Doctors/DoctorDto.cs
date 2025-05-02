namespace HospitalMicroservice.Doctor.Api.Features.Doctors;

public sealed record DoctorDto
{
    public Guid Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Specialization { get; init; }
    public string Gender { get; init; }
}
