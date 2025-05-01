using HospitalMicroservice.Patient.Api.Repositories;
using HospitalMicroservice.Shared;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Create;

public class CreatePatientCommandHandler(AppDbContext context) : IRequestHandler<CreatePatientCommand, ServiceResult<CreatePatientResponse>>
{
    public async Task<ServiceResult<CreatePatientResponse>> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
    {
        var existPatient =
               await context.Patients.AnyAsync(x => x.IdentityNumber == request.IdentityNumber, cancellationToken: cancellationToken);


        if (existPatient)
        {
            ServiceResult<CreatePatientResponse>.Error("Patient already exists",
                $"The patient '{request.FirstName + request.LastName}' already exists", HttpStatusCode.BadRequest);
        }


        var patient = new Patient
        {
            Id = NewId.NextSequentialGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            IdentityNumber = request.IdentityNumber,
            BirthDate = request.BirthDate,
            Address = request.Address,
            Email = request.Email,
            Gender = request.Gender,
            PhoneNumber = request.PhoneNumber,
            Created = DateTime.Now

        };


        await context.AddAsync(patient, cancellationToken);

        await context.SaveChangesAsync(cancellationToken);


        return ServiceResult<CreatePatientResponse>.SuccessAsCreated(new CreatePatientResponse(patient.Id),
             $"/api/patients/{patient.Id}");
    }
}

