using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        List<Category> List();
        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);



    }
}
