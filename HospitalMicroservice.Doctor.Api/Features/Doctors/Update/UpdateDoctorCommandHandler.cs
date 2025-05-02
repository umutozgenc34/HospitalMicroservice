using AutoMapper;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Update;

public class UpdateDoctorCommandHandler(AppDbContext context,IMapper mapper) : IRequestHandler<UpdateDoctorCommand, ServiceResult>
{
    public async Task<ServiceResult> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
    {
        var doctor = await context.Doctors.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);
        if (doctor is null)
        {
            return ServiceResult.Error("Doctor not found", $"This doctor could not be found by this ID. {request.Id} ", HttpStatusCode.NotFound);
        }

        doctor = mapper.Map(request, doctor);
        await context.SaveChangesAsync(cancellationToken);

        return ServiceResult.SuccessAsNoContent();
    }
}
