using MediatR;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Queries.AppUserQueries;
using SamCar472.Application.Features.Mediator.Queries.BloqQueries;

namespace SamCar472.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Profile()
        {
            var username = User.Identity.Name;

            var query = new GetUserInfosQuery();
            query.Username = username;

            var user = await _mediator.Send(query);
            ViewBag.AppUserId = user.AppUserId;

            return View(user);
        }

        public async Task<IActionResult> BlogList()
        {
            var username = User.Identity.Name;
            // blogtitle / blogCoverImgUrl / commentCount / categoryName
            var query = new GetUserBlogListByUsernameQuery();
            query.Username = username;
            var values = await _mediator.Send(query);

            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int blogId)
        {
            return View();
        }
    }
}
