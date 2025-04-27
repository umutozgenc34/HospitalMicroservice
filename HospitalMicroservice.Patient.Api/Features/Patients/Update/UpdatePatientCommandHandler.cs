using AutoMapper;
using HospitalMicroservice.Patient.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;
namespace HospitalMicroservice.Patient.Api.Features.Patients.Update;

public class UpdatePatientCommandHandler(AppDbContext context,IMapper mapper) : IRequestHandler<UpdatePatientCommand, ServiceResult>
{
    public async Task<ServiceResult> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
    {
        var patient = await context.Patients.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);
        if (patient is null)
        {
            return ServiceResult.Error("Patient not found", $"This patient could not be found by this ID. {request.Id} ", HttpStatusCode.NotFound);
        }

        patient = mapper.Map(request, patient);
        await context.SaveChangesAsync(cancellationToken);

        return ServiceResult.SuccessAsNoContent();
    }
}