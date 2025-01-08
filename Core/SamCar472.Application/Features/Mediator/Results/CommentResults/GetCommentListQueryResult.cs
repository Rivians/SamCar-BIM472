using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Results.CommentResults
{
    public class GetCommentListQueryResult
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
