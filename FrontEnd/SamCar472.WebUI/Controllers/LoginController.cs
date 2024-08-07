﻿using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Queries.AppUserQueries;
using SamCar472.Application.Interfaces;
using SamCar472.Domain.Entities;
using SamCar472.Dto.LoginDtos;
using System.Security.Claims;

namespace SamCar472.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMediator _mediator;
        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(GetCheckAppUserQuery query)
        {
            var values = await _mediator.Send(query);

            if (values.IsExist)
            {
                GetAppUserByUsernameQuery query2 = new GetAppUserByUsernameQuery();
                query2.Username = query.Username;
                var values2 = await _mediator.Send(query2);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, query.Username ),
                    new Claim(ClaimTypes.Role, values.RoleName)
                };
                var userIdendity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdendity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Default");
            }
            else
            {
                return View();
            }
        }
    }
}
