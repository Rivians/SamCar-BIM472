using MediatR;
using SamCar472.Application.Features.Mediator.Queries.AppUserQueries;
using SamCar472.Application.Features.Mediator.Results.AppUserResults;
using SamCar472.Application.Interfaces;
using SamCar472.Application.Interfaces.AppUserInterfaces;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetAppUserByUsernameQueryHandler : IRequestHandler<GetAppUserByUsernameQuery, GetAppUserByUsernameQueryResult>
    {
        private readonly IAppUserRepository _repository;

        public GetAppUserByUsernameQueryHandler(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAppUserByUsernameQueryResult> Handle(GetAppUserByUsernameQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAppUserByUsername(request.Username);
            return new GetAppUserByUsernameQueryResult
            {
                AppUserID = value.AppUserID,
                Username = value.Username,
                Name = value.Name,
                Surname = value.Surname,
                Password = value.Password,
                Email = value.Email,
                CoverImageUrl = value.CoverImageUrl
            };
        }
    }
}
