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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDBcontext _db;
        public ProductRepository(AppDBcontext db) : base(db)  //base means pass this parameter to the base class
        {
            _db = db;
        }
        public void Update(Product obj)
        {
           var objFromDb = _db.Products.FirstOrDefault(u=>u.ID==obj.ID);
            if (objFromDb != null)
            { 
                objFromDb.Title = obj.Title; 
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price = obj.Price; 
                objFromDb.Price50 = obj.Price50; 
                objFromDb.Price100 = obj.Price100;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Description = obj.Description;
                objFromDb.Author = obj.Author;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.CoverTypeID = obj.CoverTypeID;
                if(obj.ImageUrl!=null)
                    objFromDb.ImageUrl = obj.ImageUrl;
            }
        }
    }
}
