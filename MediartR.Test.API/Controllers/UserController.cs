using MediartR.Test.Common.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediartR.Test.API.Controllers
{
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _mediator.Send(new GetAllUsersQuery());
            return Ok(response);
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetAllUsers(string username)
        {
            var response = await _mediator.Send(new GetUserByUsername { Username = username});
            return response != null ? Ok(response) : NotFound(); 
        }
    }
}
