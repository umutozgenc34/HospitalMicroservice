using AutoMapper;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.GetAll;

public class GetAllDoctorsQueryHandler(AppDbContext context,IMapper mapper) : IRequestHandler<GetAllDoctorsQuery, ServiceResult<List<DoctorDto>>>
{
    public async Task<ServiceResult<List<DoctorDto>>> Handle(GetAllDoctorsQuery request, CancellationToken cancellationToken)
    {
        var doctors = await context.Doctors.ToListAsync(cancellationToken: cancellationToken);

        var doctorsAsDto = mapper.Map<List<DoctorDto>>(doctors);

        return ServiceResult<List<DoctorDto>>.SuccessAsOk(doctorsAsDto);

    }
}