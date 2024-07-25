using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Interfaces.AppUserInterfaces
{
    public interface IAppUserRepository
    {
        public AppUser GetAppUserByUsername(string username);
        public AppUser GetAppUserByLoginParamsWithRole(string username,string password);
    }
}
