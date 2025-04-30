using HospitalMicroservice.Doctor.Api.Repositories;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors;

public class Doctor : BaseEntity
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Specialization { get; set; } = default!;
    public string Gender { get; set; } = default!;
}

