using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodyBook.DataAccess.Repository.IRepository;
using WoodyBook.Model;
using WoodyBooks.DataAccess;

namespace WoodyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private AppDBcontext _db;
        public ApplicationUserRepository(AppDBcontext db) : base(db)  //base means pass this parameter to the base class
        {
            _db = db;
        }
        
    }
}
