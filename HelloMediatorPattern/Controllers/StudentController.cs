using HelloMediatorPattern.Handler;
using HelloMediatorPattern.ViewModels.Request;
using HelloMediatorPattern.ViewModels.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HelloMediatorPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<string> AddStudent(StudentRequest studentViewModel)
        {
            ResponseStudentViewModel s =await _mediator.Send(studentViewModel);

            return "sdhdfjdgjdjfgdjgf";
        }

    }
}
