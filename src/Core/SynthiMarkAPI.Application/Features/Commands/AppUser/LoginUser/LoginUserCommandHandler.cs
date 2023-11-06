﻿using MediatR;
using Microsoft.AspNetCore.Identity;
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
        readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;
        readonly SignInManager<Domain.Entities.Identity.AppUser> _signInManager;
        readonly ITokenHandler _tokenHandler;

        public LoginUserCommandHandler(SignInManager<Domain.Entities.Identity.AppUser> signInManager, ITokenHandler tokenHandler, UserManager<Domain.Entities.Identity.AppUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.AppUser user = await _userManager.FindByNameAsync(request.UsernameOrEmail);

            if (user == null)
                user = await _userManager.FindByEmailAsync(request.UsernameOrEmail);

            if (user == null)
                throw new NotFoundUserException();

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (result.Succeeded)
            {
                Token token = _tokenHandler.CreateAccessToken(5);
                return new LoginUserSuccessCommandResponse
                { Token = token };

            }

            //return new LoginUserErrorCommandResponse { Message = "Kullanıcı adı veya şifre hatalı"};
            throw new AuthenticationErrorException();

        }
    }
}
