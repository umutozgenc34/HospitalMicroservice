using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;

namespace HospitalMicroservice.Doctor.Api.Repositories;

public class DoctorConfiguration : IEntityTypeConfiguration<Features.Doctors.Doctor>
{
    public void Configure(EntityTypeBuilder<Features.Doctors.Doctor> builder)
    {
        builder.ToCollection("doctors");
        builder.HasKey(d => d.Id);
        builder.Property(x => x.Id).HasElementName("_id");
        builder.Property(x => x.Id).ValueGeneratedNever();
        builder.Property(x => x.FirstName).HasElementName("firstName").HasMaxLength(100);
        builder.Property(x => x.LastName).HasElementName("lastName").HasMaxLength(100);
        builder.Property(x => x.Gender).HasElementName("gender").HasMaxLength(5);
        builder.Property(x => x.Specialization).HasElementName("specialization").HasMaxLength(100);
    }
}
