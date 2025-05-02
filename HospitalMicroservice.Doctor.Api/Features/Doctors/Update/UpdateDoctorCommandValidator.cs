using FluentValidation;

namespace HospitalMicroservice.Doctor.Api.Features.Doctors.Update;

public class UpdateDoctorCommandValidator : AbstractValidator<UpdateDoctorCommand>
{
    public UpdateDoctorCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Doctor Id is required.");

        RuleFor(x => x.FirstName)
           .NotEmpty().WithMessage("First name is required.")
           .MaximumLength(100).WithMessage("First name must not exceed 100 characters.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Last name is required.")
            .MaximumLength(100).WithMessage("Last name must not exceed 100 characters.");

        RuleFor(x => x.Specialization)
            .NotEmpty().WithMessage("Specialization is required.")
            .MaximumLength(100).WithMessage("Specialization must not exceed 100 characters.");

        RuleFor(x => x.Gender)
            .NotEmpty().WithMessage("Gender is required.")
            .Must(g => g == "Male" || g == "Female" || g == "Other")
            .WithMessage("Gender must be either 'Male', 'Female', or 'Other'.");
    }
}
