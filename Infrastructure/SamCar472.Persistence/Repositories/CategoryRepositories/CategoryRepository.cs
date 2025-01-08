using SamCar472.Application.Interfaces.CategoryInterfaces;
using SamCar472.Domain.Entities;
using SamCar472.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Persistence.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SamCarContext _context;
        public CategoryRepository(SamCarContext context)
        {
            _context = context;
        }

    }
}
