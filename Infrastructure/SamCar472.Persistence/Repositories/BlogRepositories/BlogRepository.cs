using Microsoft.EntityFrameworkCore;
using SamCar472.Application.Dtos.BlogDtos;
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

        public List<UserBlogListDto> GetUserBlogListByAuthorUsernameWithCommentCountAndCategory(string username)
        {
            var authorValues = _context.Auhtors.Where(x => x.Username == username)
                .Include(x => x.Blogs)
                    .ThenInclude(y => y.Comments)
                .Include(x => x.Blogs)
                    .ThenInclude(y => y.Category)
                .FirstOrDefault();

            var blogDto = authorValues.Blogs.Select(x => new UserBlogListDto
            {
                BlogID = x.BlogID,
                Title = x.Title,
                CoverImageUrl = x.CoverImageUrl,
                CategoryName = x.Category.Name,
                CommentCount = x.Comments.Count(),
                CreatedTime = x.CreatedTime
            }).ToList();

            return blogDto;                                       
        }

        public List<Blog> GetBlogListWithCategoryByUser(int appUserId)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetLast5BlogsWithAuthors()
        {
            return _context.Blogs.Include(_x => _x.Author).OrderByDescending(x => x.CreatedTime).Take(5).ToList();
        }
    }
}
