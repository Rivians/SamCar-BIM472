using MediatR;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Commands.AppUserCommands;
using SamCar472.Dto.RegisterDtos;

namespace SamCar472.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IMediator _mediator;
        public RegisterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateAppUserCommand command)
        {
            if(command != null)
            {
                await _mediator.Send(command);
                return RedirectToAction("Index","Login");
            }
            else 
            {
                return View(); 
            }
        }
    }
}
