using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;

namespace HospitalMicroservice.Patient.Api.Repositories;

public class PatientConfiguration : IEntityTypeConfiguration<Features.Patients.Patient>
{
    public void Configure(EntityTypeBuilder<Features.Patients.Patient> builder)
    {
        builder.ToCollection("patients");
        builder.HasKey(x=> x.Id);

        builder.Property(x => x.Id).ValueGeneratedNever();
        builder.Property(x => x.FirstName).HasElementName("firstName").HasMaxLength(100);
        builder.Property(x => x.LastName).HasElementName("lastName").HasMaxLength(100);
        builder.Property(x => x.Created).HasElementName("created");
        builder.Property(x => x.IdentityNumber).HasElementName("identityNumber").HasMaxLength(11);
        builder.Property(x => x.Gender).HasElementName("gender").HasMaxLength(5);
        builder.Property(x => x.BirthDate).HasElementName("birthDate");
        builder.Property(x => x.PhoneNumber).HasElementName("phoneNumber").HasMaxLength(15);
        builder.Property(x => x.Email).HasElementName("email").HasMaxLength(100);
        builder.Property(x => x.Address).HasElementName("address").HasMaxLength(200);
        
    }
}
