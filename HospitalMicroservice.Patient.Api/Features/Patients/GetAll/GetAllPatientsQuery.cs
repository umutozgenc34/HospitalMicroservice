using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Patient.Api.Features.Patients.GetAll;

public class GetAllPatientsQuery : IRequest<ServiceResult<List<PatientDto>>>;

