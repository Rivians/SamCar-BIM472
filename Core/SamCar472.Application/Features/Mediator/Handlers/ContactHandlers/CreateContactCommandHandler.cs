using MediatR;
using SamCar472.Application.Enums;
using SamCar472.Application.Features.Mediator.Commands.ContactCommands;
using SamCar472.Application.Interfaces;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand>
    {
        private readonly IRepository<Contact> _repository;
        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = request.Name,
                Email = request.Email,
                Subject = request.Subject,
                Message = request.Message,
                SendDate = DateTime.Now,
            });
        }
    }
}
