using MediatR;
using SamCar472.Application.Features.Mediator.Queries.AppUserQueries;
using SamCar472.Application.Features.Mediator.Results.AppUserResults;
using SamCar472.Application.Interfaces;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetUserInfosQueryHandler : IRequestHandler<GetUserInfosQuery, GetUserInfosQueryResult>
    {
        private readonly IRepository<AppUser> _repository;
        public GetUserInfosQueryHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<GetUserInfosQueryResult> Handle(GetUserInfosQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.Username == request.Username);
            return new GetUserInfosQueryResult
            {
                AppUserId = values.AppUserID,
                Name = values.Name,
                Surname = values.Surname,
                Username = values.Username,
                Email = values.Email,
                Password = values.Password,
                CoverImageUrl = values.CoverImageUrl,
                AppRoleId = values.AppRoleID
            };
        }
    }
}
