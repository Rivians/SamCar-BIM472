using MediatR;
using SamCar472.Application.Features.Mediator.Queries.BloqQueries;
using SamCar472.Application.Features.Mediator.Results.BlogResults;
using SamCar472.Application.Interfaces.BlogInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetUserBlogListByUsernameQueryHandler : IRequestHandler<GetUserBlogListByUsernameQuery, List<GetUserBlogListByUsernameQueryResult>>
    {
        private readonly IBlogRepository _repository;
        public GetUserBlogListByUsernameQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetUserBlogListByUsernameQueryResult>> Handle(GetUserBlogListByUsernameQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetUserBlogListByAuthorUsernameWithCommentCountAndCategory(request.Username);
            return values.Select(x => new GetUserBlogListByUsernameQueryResult()
            {
                BlogID = x.BlogID,
                Title = x.Title,
                CreatedTime = x.CreatedTime,
                CategoryName = x.CategoryName,
                CommentCount = x.CommentCount,
                CoverImageUrl = x.CoverImageUrl
            }).ToList();
        }
    }
}
