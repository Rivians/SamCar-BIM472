﻿using MediatR;
using SamCar472.Application.Features.Mediator.Results.CommentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetCommentListQuery : IRequest<List<GetCommentListQueryResult>>
    {
    }
}
