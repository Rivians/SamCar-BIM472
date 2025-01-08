using MediatR;
using SamCar472.Application.Features.Mediator.Results.CategoryResults;
using SamCar472.Application.Interfaces.CategoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetCategoryListQuery : IRequest<List<GetCategoryListQueryResult>>
    {       
    }
}
