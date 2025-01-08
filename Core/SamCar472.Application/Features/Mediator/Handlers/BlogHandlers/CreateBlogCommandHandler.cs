using MediatR;
using SamCar472.Application.Features.Mediator.Commands.BlogCommands;
using SamCar472.Application.Interfaces;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repositories;
        public CreateBlogCommandHandler(IRepository<Blog> repositories)
        {
            _repositories = repositories;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repositories.CreateAsync(new Blog
            {
                Title = request.Title,
                ShortDescription = request.ShortDescription,
                Description = request.Description,
                CoverImageUrl = request.CoverImageUrl,
                CreatedTime = DateTime.Now,
                CategoryID = request.CategoryId
            });
        }
    }
}
