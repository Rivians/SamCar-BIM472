using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogListWithCategoryByUserQueryResult
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
