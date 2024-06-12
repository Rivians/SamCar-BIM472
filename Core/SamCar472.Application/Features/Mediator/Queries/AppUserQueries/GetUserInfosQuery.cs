using MediatR;
using SamCar472.Application.Features.Mediator.Results.AppUserResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Queries.AppUserQueries
{
    public class GetUserInfosQuery : IRequest<GetUserInfosQueryResult>
    {
        public string Username { get; set; }

    }
}
