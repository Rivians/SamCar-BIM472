using MediatR;
using SamCar472.Application.Features.Mediator.Results.BlogResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Queries.BloqQueries
{
    public class GetAllBlogsQuery : IRequest<List<GetAllBlogsQueryResult>>
    {
    }
}
