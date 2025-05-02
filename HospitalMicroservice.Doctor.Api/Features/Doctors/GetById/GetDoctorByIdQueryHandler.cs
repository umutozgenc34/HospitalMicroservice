using AutoMapper;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.GetById;

public class GetDoctorByIdQueryHandler(AppDbContext context,IMapper mapper) : IRequestHandler<GetDoctorByIdQuery, ServiceResult<DoctorDto>>
{
    public async Task<ServiceResult<DoctorDto>> Handle(GetDoctorByIdQuery request, CancellationToken cancellationToken)
    {
        var doctor = await context.Doctors.FindAsync(request.Id,cancellationToken);
        if (doctor is null)
        {
            return ServiceResult<DoctorDto>.Error("Doctor not found", $"This doctor could not be found by this ID. {request.Id} ", System.Net.HttpStatusCode.NotFound);
        }

        var doctorAsDto = mapper.Map<DoctorDto>(doctor);
        return ServiceResult<DoctorDto>.SuccessAsOk(doctorAsDto);
    }
}
