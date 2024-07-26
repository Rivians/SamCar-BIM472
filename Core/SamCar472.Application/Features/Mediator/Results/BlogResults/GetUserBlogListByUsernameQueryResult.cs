using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Results.BlogResults
{
    public class GetUserBlogListByUsernameQueryResult
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CategoryName { get; set; }
        public int CommentCount { get; set; }
    }
}
