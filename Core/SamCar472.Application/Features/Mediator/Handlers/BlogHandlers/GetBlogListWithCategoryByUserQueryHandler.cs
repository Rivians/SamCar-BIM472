using MediatR;
using SamCar472.Application.Features.Mediator.Queries.BloqQueries;
using SamCar472.Application.Features.Mediator.Results.BlogResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.BlogHandlers
{
    internal class GetBlogListWithCategoryByUserQueryHandler : IRequestHandler<GetBlogListWithCategoryByUserQuery, List<GetBlogListWithCategoryByUserQueryResult>>
    {
        //private readonly 

        public Task<List<GetBlogListWithCategoryByUserQueryResult>> Handle(GetBlogListWithCategoryByUserQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
