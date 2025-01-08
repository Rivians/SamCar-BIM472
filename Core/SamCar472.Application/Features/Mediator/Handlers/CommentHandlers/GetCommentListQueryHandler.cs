using MediatR;
using SamCar472.Application.Features.Mediator.Queries.CommentQueries;
using SamCar472.Application.Features.Mediator.Results.CommentResults;
using SamCar472.Application.Interfaces;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentListQueryHandler : IRequestHandler<GetCommentListQuery, List<GetCommentListQueryResult>>
    {
        private readonly IRepository<Comment> _repository;
        public GetCommentListQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCommentListQueryResult>> Handle(GetCommentListQuery request, CancellationToken cancellationToken)
        {
            var comments = await _repository.GetAllAsync();
            return comments.Select(x => new GetCommentListQueryResult
            {
                CommentID = x.CommentID,
                Name = x.Name,
                Email = x.Email,
                CreatedTime = x.CreatedTime,
                Description = x.Description,
            }).ToList();
        }
    }
}
