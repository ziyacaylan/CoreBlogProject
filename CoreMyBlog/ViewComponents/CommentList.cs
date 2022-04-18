using CoreMyBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMyBlog.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                     UserName="Ziya"
                },
                new UserComment
                {
                     ID=2,
                      UserName="Buğra"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Güzin"
                }
            };
            return View(commentvalues);
        }
    }
}
