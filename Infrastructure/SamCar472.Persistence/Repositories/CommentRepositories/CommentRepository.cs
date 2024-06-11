using Microsoft.EntityFrameworkCore;
using SamCar472.Application.Interfaces.CommentInterfaces;
using SamCar472.Domain.Entities;
using SamCar472.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly SamCarContext _context;
        public CommentRepository(SamCarContext context)
        {
            _context = context;
        }

        public int GetCommentCountByBlog(int id)
        {
            return _context.Comments.Where(x => x.BlogID == id).Count();
        }

        public List<Comment> GetCommentListByBlog(int id)
        {
            return _context.Comments.Where(x => x.BlogID == id).ToList();
        }
    }
}
