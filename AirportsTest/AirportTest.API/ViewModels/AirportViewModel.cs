using AirportTest.API.ViewModels.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace AirportTest.API.ViewModels
{
    public class AirportViewModel : IValidatableObject
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public double Lat { get; set; }

        public double Lon { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new AirportViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}
