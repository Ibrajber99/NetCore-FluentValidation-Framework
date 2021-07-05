using FluentValidationService.Application.Services;
using FluentValidationService.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TestTakerController : Controller
    {
        private readonly ITestService _testService;

        public TestTakerController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpPost(Name ="Create")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TestTaker> Create([FromBody] TestTaker testTaker) => _testService.SaveTestTaker(testTaker);

        [HttpPut(Name = "Update")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TestTaker> Update([FromBody] TestTaker testTaker) => _testService.SaveTestTaker(testTaker);

    }
}
