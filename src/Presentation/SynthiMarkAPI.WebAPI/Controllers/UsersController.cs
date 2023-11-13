using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SynthiMarkAPI.Application.Features.Commands.AppUser.CreateUser;
using SynthiMarkAPI.Application.Features.Commands.AppUser.FacebookLogin;
using SynthiMarkAPI.Application.Features.Commands.AppUser.GoogleLogin;
using SynthiMarkAPI.Application.Features.Commands.AppUser.LoginUser;

namespace SynthiMarkAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }

        
    }
}
