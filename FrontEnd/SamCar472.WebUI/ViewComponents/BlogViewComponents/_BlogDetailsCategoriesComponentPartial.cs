using MediatR;
using Microsoft.AspNetCore.Mvc;
using SamCar472.Application.Features.Mediator.Queries.CategoryQueries;

namespace SamCar472.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsCategoriesComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;
        public _BlogDetailsCategoriesComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetCategoryListQuery());
            return View(values);
        }
    }
}
