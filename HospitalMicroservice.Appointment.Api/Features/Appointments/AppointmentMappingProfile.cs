using AutoMapper;
using HospitalMicroservice.Appointment.Api.Features.Appointments.Create;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments;

public class AppointmentMappingProfile : Profile
{
    public AppointmentMappingProfile()
    {
        CreateMap<CreateAppointmentCommand, Appointment>();
        CreateMap<Appointment, AppointmentDto>().ReverseMap();
    }
}
