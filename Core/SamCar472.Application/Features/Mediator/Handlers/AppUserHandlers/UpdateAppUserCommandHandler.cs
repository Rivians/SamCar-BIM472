using MediatR;
using SamCar472.Application.Features.Mediator.Commands.AppUserCommands;
using SamCar472.Application.Interfaces;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class UpdateAppUserCommandHandler : IRequestHandler<UpdateAppUserCommand>
    {
        private readonly IRepository<AppUser> _repository;
        public UpdateAppUserCommandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            values.Name = request.Name;
            values.Surname = request.Surname;
            values.Email = request.Email;
            values.Password = request.Password;
            values.CoverImageUrl = request.CoverImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
