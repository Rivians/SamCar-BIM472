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
    public class GetCommentListByBlogQueryHandler : IRequestHandler<GetCommentListByBlogQuery, List<GetCommentListByBlogQueryResult>>
    {
        private readonly ICommentRepository _repository;
        public GetCommentListByBlogQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCommentListByBlogQueryResult>> Handle(GetCommentListByBlogQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCommentListByBlog(request.Id);
            return values.Select(x => new GetCommentListByBlogQueryResult
            {
                CommentID = x.CommentID,
                Name = x.Name,
                Description = x.Description,
                CreatedTime = x.CreatedTime,
            }).ToList();
        }
    }
}
