using MediatR;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Commands.AppUserCommands;
using SamCar472.Application.Features.Mediator.Commands.BlogCommands;
using SamCar472.Application.Features.Mediator.Queries.AppUserQueries;
using SamCar472.Application.Features.Mediator.Queries.BloqQueries;
using SamCar472.Application.Features.Mediator.Queries.CategoryQueries;
using SamCar472.Application.Features.Mediator.Queries.CommentQueries;
using SamCar472.Application.Features.Mediator.Results.CategoryResults;
using SamCar472.WebUI.ViewModels;

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

        //[HttpGet]
        //public async Task<IActionResult> AddBlog()
        //{
        //    var categories = await _mediator.Send(new GetCategoryListQuery());
        //    var categoryList = new CategoryListViewModel
        //    {
        //        categ
        //    };

        //    return View();
        //}

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

        [HttpGet]
        public async Task<IActionResult> BlogComments(int id)
        {
            var comments = await _mediator.Send(new GetCommentListByBlogQuery(id));
            var values = await _mediator.Send(new GetCommentCountByBlogQuery(id));
            ViewBag.CommentCount = values.CommentCount;

            return View(comments);
        }

        [HttpGet]
        public async Task<IActionResult> AllComments()
        {
            //var values = _mediator.Send()
            return View();
        }
    }
}
