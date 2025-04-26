using AutoMapper;
using HospitalMicroservice.Patient.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using System.Net;
namespace HospitalMicroservice.Patient.Api.Features.Patients.GetById;

public class GetByIdPatientQueryHandler(AppDbContext context, IMapper mapper) : IRequestHandler<GetByIdPatientQuery, ServiceResult<PatientDto>>
{
    public async Task<ServiceResult<PatientDto>> Handle(GetByIdPatientQuery request, CancellationToken cancellationToken)
    {
        var patient = await context.Patients.FindAsync(request.Id, cancellationToken);
        if (patient is null)
        {
            return ServiceResult<PatientDto>.Error("Patient not found", $"This patient could not be found by this ID. {request.Id} ", HttpStatusCode.NotFound);
        }
        var patientAsDto = mapper.Map<PatientDto>(patient);

        return ServiceResult<PatientDto>.SuccessAsOk(patientAsDto);
    }
}