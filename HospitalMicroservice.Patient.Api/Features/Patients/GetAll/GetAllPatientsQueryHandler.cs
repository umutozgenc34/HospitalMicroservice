using AutoMapper;
using HospitalMicroservice.Patient.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
namespace HospitalMicroservice.Patient.Api.Features.Patients.GetAll;

public class GetAllPatientsQueryHandler(AppDbContext context, IMapper mapper) : IRequestHandler<GetAllPatientsQuery, ServiceResult<List<PatientDto>>>
{
    public async Task<ServiceResult<List<PatientDto>>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
    {
        var patients = await context.Patients.ToListAsync(cancellationToken: cancellationToken);
        var patientsAsDTO = mapper.Map<List<PatientDto>>(patients);

        return ServiceResult<List<PatientDto>>.SuccessAsOk(patientsAsDTO);
    }

}