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
    public class GetCommentListByAppUserQueryHandler : IRequestHandler<GetCommentListByAppUserQuery, List<GetCommentListByAppUserQueryResult>>
    {
        private readonly ICommentRepository _repository;
        public GetCommentListByAppUserQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetCommentListByAppUserQueryResult>> Handle(GetCommentListByAppUserQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //public async Task<List<GetCommentListByAppUserQueryResult>> Handle(GetCommentListByAppUserQuery request, CancellationToken cancellationToken)
        //{
        //    //var values = await _repository.
        //}
    }
}
