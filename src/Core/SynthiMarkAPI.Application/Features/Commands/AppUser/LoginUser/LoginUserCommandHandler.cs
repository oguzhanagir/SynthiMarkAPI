using MediatR;
using Microsoft.AspNetCore.Identity;
using SynthiMarkAPI.Application.Abstractions.Services;
using SynthiMarkAPI.Application.Abstractions.Token;
using SynthiMarkAPI.Application.DTOs;
using SynthiMarkAPI.Application.Exceptions;
using SynthiMarkAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly IAuthService _authService;

        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.LoginAsync(request.UsernameOrEmail, request.Password, 60 * 60);

            return new LoginUserSuccessCommandResponse
            {
                Token = token
            };

        }
    }
}
