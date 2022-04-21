using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface INewsLetterService
    {
        void NewsLetterAdd(NewsLetter newsLetter);
        void NewsLetterUpdate(NewsLetter newsLetter);
        void NewsLetterDelete(NewsLetter newsLetter);
        List<NewsLetter> GetList();
        NewsLetter GetByID(int id);

    }
}
