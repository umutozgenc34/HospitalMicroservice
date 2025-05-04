using FluentValidation;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.Create;

public class CreateAppointmentCommandValidator : AbstractValidator<CreateAppointmentCommand>
{
    public CreateAppointmentCommandValidator()
    {
        RuleFor(x => x.DoctorId).NotEmpty().WithMessage("DoctorId is required.");
        RuleFor(x => x.PatientId).NotEmpty().WithMessage("PatientId is required.");
        RuleFor(x => x.AppointmentDate).NotEmpty().WithMessage("AppointmentDate is required.");
    }
}
