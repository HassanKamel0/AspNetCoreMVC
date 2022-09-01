using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodyBook.Model;

namespace WoodyBook.DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
        void UpdateStatus(int id,string orderstatus,string? paymentStatus=null);
        void UpdateStripePaymentID(int id, string sessionId, string PaymentIntentId);
    }
}
