using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodyBook.DataAccess.Repository.IRepository;
using WoodyBooks.DataAccess;

namespace WoodyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Model.Category>, ICategoryRepository
    {
        private AppDBcontext _db;
        public CategoryRepository(AppDBcontext db) : base(db)  //base means pass this parameter to the base class
        {
            _db = db;
        }
        public void Update(Model.Category obj)
        {
           _db.Categories.Update(obj);
        }
    }
}
