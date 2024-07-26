using SamCar472.Application.Dtos.BlogDtos;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public List<Blog> GetAllBlogsWithAuthors();  
        public List<Blog> GetLast5BlogsWithAuthors();
        public List<Blog> GetBlogListWithCategoryByUser(int appUserId);
        public List<UserBlogListDto> GetUserBlogListByAuthorUsernameWithCommentCountAndCategory(string username);
    }
}
