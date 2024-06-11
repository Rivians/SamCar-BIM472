using MediatR;
using SamCar472.Application.Features.Mediator.Queries.CommentQueries;
using SamCar472.Application.Features.Mediator.Results.CommentResults;
using SamCar472.Application.Interfaces.CommentInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentCountByBlogQueryHandler : IRequestHandler<GetCommentCountByBlogQuery, GetCommentCountByBlogQueryResult>
    {
        private readonly ICommentRepository _repository;
        public GetCommentCountByBlogQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCommentCountByBlogQueryResult> Handle(GetCommentCountByBlogQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCommentCountByBlog(request.Id);
            return new GetCommentCountByBlogQueryResult
            {
                BlogCount = value
            };
        }
    }
}
