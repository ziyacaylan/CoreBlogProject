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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public List<Blog> GetBlogListWithCategory()
        {
           return _blogDal.GetListWithCategory();
        }
        public Blog GetByID(int id)
        {
            return _blogDal.GetByID(id);
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().TakeLast(3).ToList();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Blog t)
        {
            _blogDal.Update(t);
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }
        public List<Blog> GetListWithCategoryByWriterBlogManager (int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id).Where(x=>x.BlogStatus==true).ToList();
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.GetByID(id);
        }
    }
}
