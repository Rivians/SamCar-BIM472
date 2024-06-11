using MediatR;
using SamCar472.Application.Features.Mediator.Queries.CategoryQueries;
using SamCar472.Application.Features.Mediator.Results.CategoryResults;
using SamCar472.Application.Interfaces;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryListQueryHandler : IRequestHandler<GetCategoryListQuery, List<GetCategoryListQueryResult>>
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryListQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryListQueryResult>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryListQueryResult
            {
                CategoryID = x.CategoryID,
                CategoryName = x.Name
            }).ToList();
        }
    }
}
