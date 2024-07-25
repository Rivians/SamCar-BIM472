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
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IAppUserRepository _repository2;
        public GetCheckAppUserQueryHandler(IRepository<AppUser> repository, IAppUserRepository repository2)
        {
            _repository = repository;
            _repository2 = repository2;
        }

        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            //var value = await _repository.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);

            var user = _repository2.GetAppUserByLoginParamsWithRole(request.Username, request.Password);

            var data = new GetCheckAppUserQueryResult();
            if(user != null)
            {
                data.IsExist = true;
                data.Username = request.Username;
                data.Password = request.Password;
                data.RoleName = user.AppRole.AppRoleName; 

                return data;
            }
            else
            {
                data.IsExist = false;

                return data;
            }
        }
    }
}
