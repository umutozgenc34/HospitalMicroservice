using AutoMapper;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Create;

public class CreateDoctorCommandHandler(AppDbContext context,IMapper mapper) : IRequestHandler<CreateDoctorCommand, ServiceResult<CreateDoctorResponse>>
{
    public async Task<ServiceResult<CreateDoctorResponse>> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
    {
        var existDoctor =
              await context.Doctors.AnyAsync(x => x.FirstName == request.FirstName && x.LastName == request.LastName , cancellationToken: cancellationToken);


        if (existDoctor)
        {
            ServiceResult<CreateDoctorResponse>.Error("Doctor already exists",
                $"The Doctor '{request.FirstName + request.LastName}' already exists", HttpStatusCode.BadRequest);
        }


        var doctor = mapper.Map<Doctor>(request);
        doctor.Id = NewId.NextSequentialGuid();


        await context.AddAsync(doctor, cancellationToken);

        await context.SaveChangesAsync(cancellationToken);


        return ServiceResult<CreateDoctorResponse>.SuccessAsCreated(new CreateDoctorResponse(doctor.Id),
             $"/api/doctors/{doctor.Id}");
    }
}
