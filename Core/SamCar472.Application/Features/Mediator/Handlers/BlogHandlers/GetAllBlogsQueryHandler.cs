using MediatR;
using SamCar472.Application.Features.Mediator.Queries.BloqQueries;
using SamCar472.Application.Features.Mediator.Results.BlogResults;
using SamCar472.Application.Interfaces;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogsQueryHandler : IRequestHandler<GetAllBlogsQuery, List<GetAllBlogsQueryResult>>
    {
        private readonly IRepository<Blog> _repository;
        public GetAllBlogsQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllBlogsQueryResult>> Handle(GetAllBlogsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAllBlogsQueryResult
            {
                BlogID = x.BlogID,
                BlogName = x.Title,
                CreatedTime = x.CreatedTime,
                BlogStatus = x.Status
            }).ToList();
        }
    }
}
