using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodyBook.DataAccess.Repository.IRepository;
using WoodyBooks.DataAccess;

namespace WoodyBook.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<Model.CoverType>, ICoverTypeRepository
    {
        private AppDBcontext _db;
        public CoverTypeRepository(AppDBcontext db) : base(db)
        {
            _db = db;
        }
        public void Update(Model.CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}
