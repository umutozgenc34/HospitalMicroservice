using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Delete;

public record DeleteDoctorCommand(Guid Id) : IRequest<ServiceResult>;
