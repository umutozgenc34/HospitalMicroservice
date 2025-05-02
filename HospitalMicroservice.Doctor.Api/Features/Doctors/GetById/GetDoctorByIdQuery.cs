using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.GetById;

public record GetDoctorByIdQuery(Guid Id) : IRequest<ServiceResult<DoctorDto>>;

