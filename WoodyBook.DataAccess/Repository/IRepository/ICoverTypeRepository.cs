using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodyBook.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository:IRepository<Model.CoverType>
    {
        void Update(Model.CoverType obj);
    }
}
