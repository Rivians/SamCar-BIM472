using MediatR;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Queries.CommentQueries;

namespace SamCar472.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsCommentsComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;
        public _BlogDetailsCommentsComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _mediator.Send(new GetCommentListByBlogQuery(id));
            var blogCount = await _mediator.Send(new GetCommentCountByBlogQuery(id));
            ViewBag.blogId = id;
            ViewBag.BlogCount = blogCount.BlogCount;

            return View(values);
        }
    }
}
