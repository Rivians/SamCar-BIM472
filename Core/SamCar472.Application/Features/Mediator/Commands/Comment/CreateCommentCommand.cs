using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Commands.Comment
{
    public class CreateCommentCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int BlogID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
