using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Commands.AppUserCommands;
using SamCar472.Application.Features.Mediator.Commands.BlogCommands;
using SamCar472.Application.Features.Mediator.Queries.AppUserQueries;
using SamCar472.Application.Features.Mediator.Queries.BloqQueries;

namespace SamCar472.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IMediator _mediator;
        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var username = User.Identity.Name;

            var query = new GetUserInfosQuery();
            query.Username = username;

            var user = await _mediator.Send(query);
            ViewBag.AppUserId = user.AppUserId;

            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetAllBlogsQuery());

            return View(values);
        }

        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return RedirectToAction("Profile");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProfile(int id)
        {
            var username = User.Identity.Name;

            var query = new GetUserInfosQuery();
            query.Username = username;

            var user = await _mediator.Send(query);

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(UpdateAppUserCommand command)
        {
            await _mediator.Send(command);

            return RedirectToAction("Profile");
        }

        //[HttpGet]
        //public async Task<IActionResult> BlogList(int id)
        //{
        //    return View();
        //    //}

        //    //[HttpGet]
        //    //public async Task<IActionResult> BlogListAdmin()
        //    //{
        //    //    var username = User.Identity.Name;

        //    //    var query = new GetUserInfosQuery();
        //    //    query.Username = username;            
        //    //    var user = await _mediator.Send(query);

        //    //    if(user.AppRoleId == 1)
        //    //    {
        //    //        var values = _mediator.Send(new GetAllBlogsQuery());
        //    //        return View(values);
        //    //    }
        //    //    else
        //    //    {
        //    //        return RedirectToAction("Profile");
        //    //    }
        //    //}
        //}
    }
}
