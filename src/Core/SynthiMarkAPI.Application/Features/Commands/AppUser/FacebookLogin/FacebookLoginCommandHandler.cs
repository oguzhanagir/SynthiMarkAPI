using MediatR;
using Microsoft.AspNetCore.Identity;
using SynthiMarkAPI.Application.Abstractions.Services;
using SynthiMarkAPI.Application.Abstractions.Token;
using SynthiMarkAPI.Application.DTOs;
using SynthiMarkAPI.Application.DTOs.Facebook;
using System.Text.Json;

namespace SynthiMarkAPI.Application.Features.Commands.AppUser.FacebookLogin
{
    public class FacebookLoginCommandHandler : IRequestHandler<FacebookLoginCommandRequest, FacebookLoginCommandResponse>
    {
        readonly IAuthService _authService;

        public FacebookLoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<FacebookLoginCommandResponse> Handle(FacebookLoginCommandRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.FacebookLoginAsync(request.AuthToken,60*60);
            return new()
            {
                Token = token
            };
        }
    }
}
