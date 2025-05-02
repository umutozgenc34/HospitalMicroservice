using AutoMapper;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Delete;

public class DeleteDoctorCommandHandler(AppDbContext context) : IRequestHandler<DeleteDoctorCommand, ServiceResult>
{
    public async Task<ServiceResult> Handle(DeleteDoctorCommand request, CancellationToken cancellationToken)
    {
        var doctor = await context.Doctors.FindAsync(request.Id,cancellationToken);
        if (doctor is null)
        {
            return ServiceResult.Error("Doctor not found",System.Net.HttpStatusCode.NotFound);
        }

        context.Doctors.Remove(doctor);

        await context.SaveChangesAsync(cancellationToken);

        return ServiceResult.SuccessAsNoContent();
    }
}
