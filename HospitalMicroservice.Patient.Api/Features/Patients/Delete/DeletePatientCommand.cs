using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Delete;

public record DeletePatientCommand(Guid Id) : IRequest<ServiceResult>;

