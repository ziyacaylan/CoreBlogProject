using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        void WriterAdd(Writer writer);
        void WriterUpdate(Writer writer);
        void WriterDelete(Writer writer);
        List<Writer> GetList();
        Writer GetByID(int id);
        Writer TGetByFilter(Expression<Func<Writer, bool>> filter);
    }
}
