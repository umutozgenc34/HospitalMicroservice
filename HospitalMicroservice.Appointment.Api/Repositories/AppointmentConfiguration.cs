using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;

namespace HospitalMicroservice.Appointment.Api.Repositories;

public class AppointmentConfiguration : IEntityTypeConfiguration<Features.Appointments.Appointment>
{
    public void Configure(EntityTypeBuilder<Features.Appointments.Appointment> builder)
    {
        builder.ToCollection("appointments");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasElementName("_id");
        builder.Property(x => x.Id).ValueGeneratedNever();

        builder.Property(x => x.DoctorId)
            .HasElementName("doctorId")
            .IsRequired();
        builder.Property(x => x.PatientId).HasElementName("patientId").IsRequired();

        builder.Property(x => x.AppointmentDate).HasElementName("appointmentDate").IsRequired();
    }
}
