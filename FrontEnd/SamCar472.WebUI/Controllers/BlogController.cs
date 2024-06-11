using MediatR;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Commands.Comment;
using SamCar472.Application.Features.Mediator.Queries.BloqQueries;
using SamCar472.Application.Features.Mediator.Results.BlogResults;
using SamCar472.Dto.BlogDtos;

namespace SamCar472.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMediator _mediator;
        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllBlogsWithAuthorsQuery());

            return View(values);
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            var values = await _mediator.Send(new GetBlogByIdQuery(id));

            return View(values);
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);

            return RedirectToAction("Index");
        }
    }
}
