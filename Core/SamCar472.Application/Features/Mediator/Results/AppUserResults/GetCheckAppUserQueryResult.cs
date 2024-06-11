using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Features.Mediator.Results.AppUserResults
{
    public class GetCheckAppUserQueryResult
    {
        public int AppUserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsExist { get; set; }
    }
}
