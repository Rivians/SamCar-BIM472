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
    public class GetLast5BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast5BlogsWithAuthorsQuery, List<GetLast5BlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;
        public GetLast5BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast5BlogsWithAuthorsQueryResult>> Handle(GetLast5BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast5BlogsWithAuthors();
            return values.Select(x => new GetLast5BlogsWithAuthorsQueryResult
            {
                BlogID = x.BlogID,
                Title = x.Title,
                AuthorName = x.Author.Name,
                CreatedTime = x.CreatedTime,
                CoverImageUrl = x.CoverImageUrl,                
            }).ToList();
        }
    }
}
