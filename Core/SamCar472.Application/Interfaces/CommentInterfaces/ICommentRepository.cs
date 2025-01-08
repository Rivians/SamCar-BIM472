using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Application.Interfaces.CommentInterfaces
{
    public interface ICommentRepository
    {
        public List<Comment> GetCommentListByBlog(int id);
        public int GetCommentCountByBlog(int id);
        public List<Comment> GetCommentListByAppUser();
    }
}
