using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CategoryUpdate(Category comment);
        //void CategoryDelete(Category comment);
        List<Comment> GetList(int id);
        //Category GetByID(int id);
    }
}
