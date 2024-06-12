using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Results.BlogResults
{
    public class GetAllBlogsQueryResult
    {
        public int BlogID { get; set; }
        public string BlogName { get; set; }
        public string Author { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool BlogStatus { get; set; }
    }
}
