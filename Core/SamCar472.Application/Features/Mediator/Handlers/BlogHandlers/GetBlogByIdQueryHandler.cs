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
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;
        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
                BlogID = value.BlogID,
                Title = value.Title,
                Description = value.Description,
                ShortDescription = value.ShortDescription,
                CoverImageUrl = value.CoverImageUrl,
                CreatedTime = value.CreatedTime,                                
            };
        }
    }
}
