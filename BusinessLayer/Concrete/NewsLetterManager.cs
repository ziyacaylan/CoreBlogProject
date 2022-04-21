using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public NewsLetter GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetList()
        {
            throw new NotImplementedException();
        }

        public void NewsLetterAdd(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);
        }

        public void NewsLetterDelete(NewsLetter newsLetter)
        {
            _newsLetterDal.Delete(newsLetter);
        }

        public void NewsLetterUpdate(NewsLetter newsLetter)
        {
            throw new NotImplementedException();
        }
    }
}
