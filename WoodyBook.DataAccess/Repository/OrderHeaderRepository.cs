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
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private AppDBcontext _db;
        public OrderHeaderRepository(AppDBcontext db) : base(db)  //base means pass this parameter to the base class
        {
            _db = db;
        }
        public void Update(OrderHeader obj)
        {
           _db.OrderHeaders.Update(obj);
        }

        public void UpdateStatus(int id, string orderstatus, string? paymentStatus = null)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
            if (orderFromDb != null)
            {
                orderFromDb.OrderStatus = orderstatus;
                if (paymentStatus != null)
                    orderFromDb.OrderStatus = paymentStatus;
            }
        }

        public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
                orderFromDb.PaymentDate=DateTime.Now;
                orderFromDb.SessionId = sessionId;
                orderFromDb.PaymentIntentId = paymentIntentId;
             
        }
    }
}
