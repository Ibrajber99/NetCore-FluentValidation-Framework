using FluentValidationService.Application.Exceptions;
using FluentValidationService.Application.Services;
using FluentValidationService.Application.Validations;
using FluentValidationService.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValdiationService.Persistance.Services
{
    public class TestService : ITestService
    {

        public TestTaker SaveTestTaker(TestTaker testTaker)
        {
            var validationService = new TestTakerValidator();
            var validationResult = validationService.Validate(testTaker);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            return testTaker;
        }
    }
}
