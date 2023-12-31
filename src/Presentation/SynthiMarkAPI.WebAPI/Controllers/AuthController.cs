﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using SynthiMarkAPI.Application.Features.Commands.AppUser.FacebookLogin;
using SynthiMarkAPI.Application.Features.Commands.AppUser.GoogleLogin;
using SynthiMarkAPI.Application.Features.Commands.AppUser.LoginUser;
using SynthiMarkAPI.Application.Features.Commands.AppUser.RefreshTokenLogin;

namespace SynthiMarkAPI.WebAPI.Controllers
{
    public class AuthController : Controller
    {
        readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
        {
            LoginUserCommandResponse response = await _mediator.Send(loginUserCommandRequest);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> RefreshTokenLogin([FromForm]RefreshTokenLoginCommandRequest refreshTokenLoginCommandRequest)
        {
            RefreshTokenLoginCommandResponse response = await _mediator.Send(refreshTokenLoginCommandRequest);
            return Ok(response);
        }


        [HttpPost("google-login")]
        public async Task<IActionResult> GoogleLogin(GoogleLoginCommandRequest googleLoginCommandRequest)
        {
            GoogleLoginCommandResponse response = await _mediator.Send(googleLoginCommandRequest);
            return Ok(response);
        }

        [HttpPost("facebook-login")]
        public async Task<IActionResult> FacebookLogin(FacebookLoginCommandRequest facebookLoginCommandRequest)
        {
            FacebookLoginCommandResponse response = await _mediator.Send(facebookLoginCommandRequest);
            return Ok(response);
        }
    }
}
