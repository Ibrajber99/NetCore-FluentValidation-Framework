using FluentValidation;
using FluentValidationService.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidationService.Application.Validations
{
    public class TestInfoValidator : AbstractValidator<TestInfo>
    {
        public TestInfoValidator()
        {

            RuleFor(p => p.TestName).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(p => p.TestDate).Must(IsTestDateValid).WithMessage("Test date must be in the future");
        }

        private bool IsTestDateValid(DateTime testDate)
        {
            return testDate.Date > DateTime.Now.Date;
        }

    }
}
