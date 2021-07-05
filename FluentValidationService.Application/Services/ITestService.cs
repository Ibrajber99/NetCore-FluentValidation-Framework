using FluentValidationService.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidationService.Application.Services
{
    public interface ITestService
    {
        TestTaker SaveTestTaker(TestTaker testTaker);
    }
}
