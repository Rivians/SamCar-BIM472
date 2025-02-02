﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Commands.BlogCommands
{
    public class CreateBlogCommand : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }

    }
}
