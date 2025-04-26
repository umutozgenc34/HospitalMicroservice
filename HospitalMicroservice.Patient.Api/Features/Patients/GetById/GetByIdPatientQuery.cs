using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.GetById;

public record GetByIdPatientQuery(Guid Id) : IRequest<ServiceResult<PatientDto>>;

