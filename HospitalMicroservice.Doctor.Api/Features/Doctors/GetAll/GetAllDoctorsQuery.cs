using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.GetAll;

public class GetAllDoctorsQuery : IRequest<ServiceResult<List<DoctorDto>>>;


