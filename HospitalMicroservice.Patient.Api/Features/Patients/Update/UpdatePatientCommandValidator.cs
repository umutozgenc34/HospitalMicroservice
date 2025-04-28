using FluentValidation;

namespace HospitalMicroservice.Patient.Api.Features.Patients.Update;

public class UpdatePatientCommandValidator : AbstractValidator<UpdatePatientCommand>
{
    public UpdatePatientCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id is required.");

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("First name is required.")
            .MaximumLength(50)
            .WithMessage("First name must be at most 50 characters.");

        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Last name is required.")
            .MaximumLength(50)
            .WithMessage("Last name must be at most 50 characters.");

        RuleFor(x => x.IdentityNumber)
            .NotEmpty()
            .WithMessage("Identity number is required.")
            .Length(11)
            .WithMessage("Identity number must be exactly 11 characters.");

        RuleFor(x => x.BirthDate)
            .NotEmpty()
            .LessThan(DateTime.Now)
            .WithMessage("Birth date must be in the past.");

        RuleFor(x => x.Gender)
            .NotEmpty()
            .WithMessage("Gender is required.")
            .Must(gender => gender == "Male" || gender == "Female" || gender == "Other")
            .WithMessage("Gender must be 'Male', 'Female' or 'Other'.");

        RuleFor(x => x.PhoneNumber)
            .MaximumLength(20)
            .When(x => !string.IsNullOrWhiteSpace(x.PhoneNumber))
            .WithMessage("Phone number must be at most 20 characters.");

        RuleFor(x => x.Email)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.Email))
            .WithMessage("Email format is invalid.");

        RuleFor(x => x.Address)
            .MaximumLength(250)
            .When(x => !string.IsNullOrWhiteSpace(x.Address))
            .WithMessage("Address must be at most 250 characters.");
    }
}