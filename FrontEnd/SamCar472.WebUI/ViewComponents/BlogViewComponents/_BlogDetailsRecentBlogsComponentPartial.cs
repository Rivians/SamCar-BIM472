using MediatR;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Queries.BloqQueries;

namespace SamCar472.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsRecentBlogsComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;
        public _BlogDetailsRecentBlogsComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetLast5BlogsWithAuthorsQuery());

            return View(values);
        }
    }
}
