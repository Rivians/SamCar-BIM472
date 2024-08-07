﻿using Microsoft.EntityFrameworkCore;
using SamCar472.Application.Interfaces.AppUserInterfaces;
using SamCar472.Domain.Entities;
using SamCar472.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Persistence.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly SamCarContext _context;
        public AppUserRepository(SamCarContext context)
        {
            _context = context;
        }

        public AppUser GetAppUserByLoginParamsWithRole(string username, string password)
        {
            var result = _context.AppUsers.Include(x => x.AppRole).Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            return result;
        }

        public AppUser GetAppUserByUsername(string username)
        {
            return _context.AppUsers.Where(x => x.Username == username).FirstOrDefault();            
        }
    }
}
