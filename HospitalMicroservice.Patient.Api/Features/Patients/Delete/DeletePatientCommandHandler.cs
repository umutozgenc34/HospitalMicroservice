using HospitalMicroservice.Patient.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using System.Net;
namespace HospitalMicroservice.Patient.Api.Features.Patients.Delete;

public class DeletePatientCommandHandler(AppDbContext context) : IRequestHandler<DeletePatientCommand, ServiceResult>
{
    public async Task<ServiceResult> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
    {
        var patient = await context.Patients.FindAsync(request.Id, cancellationToken);
        if (patient is null)
        {
            return ServiceResult.Error("Patient not found", $"This patient could not be found by this ID. {request.Id} ", HttpStatusCode.NotFound);
        }

        context.Patients.Remove(patient);
        await context.SaveChangesAsync(cancellationToken);

        return ServiceResult.SuccessAsNoContent();

    }
}