using FluentValidation;

namespace AirportTest.API.ViewModels.Validation
{
    public class AirportViewModelValidator : AbstractValidator<AirportViewModel>
    {
        public AirportViewModelValidator()
        {
            RuleFor(p => p.Code).NotEmpty().WithMessage("Code cannot be empty");
            RuleFor(p => p.Lat).NotEmpty().WithMessage("Latitude cannot be empty");
            RuleFor(p => p.Lon).NotEmpty().WithMessage("Longitude cannot be empty");
        }
    }
}
