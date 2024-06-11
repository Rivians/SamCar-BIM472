using Microsoft.EntityFrameworkCore;
using SamCar472.Application.Interfaces.BlogInterfaces;
using SamCar472.Domain.Entities;
using SamCar472.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly SamCarContext _context;
        public BlogRepository(SamCarContext context)
        {
            _context = context;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            return _context.Blogs.Include(x => x.Author).ToList();
        }

        public List<Blog> GetLast5BlogsWithAuthors()
        {
            return _context.Blogs.Include(_x => _x.Author).OrderByDescending(x => x.CreatedTime).Take(5).ToList();
        }
    }
}
