using BlueBadge.Data;
using BlueBadge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Services
{
    public class OrdersService
    {
        private readonly Guid _orderId;
        private readonly Guid _userId;
        private readonly Guid _paymentId;

        public OrdersService(Guid userId)
        {
            _userId = userId;
        }

     
        public bool CreateOrder(OrdersCreate model)
        {
            var entity =
                new OrdersService()
                {
                    OrderId = _orderId,
                    CustomerId = _userId,
                    PaymentId = _paymentId,
                    OrderDate = model.OrderDate,
                    ShipDate = model.ShipDate,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Orders.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<OrdersListItem> GetOrders()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = 
                    ctx
                        .Orders
                        .Where(else => CustomerId == _userId)
                        .Select(
                            else =>
                                    new OrdersListItem
                                    {
                                        _orderId = e.OrderId,
                                        ShipDate = e.ShipDate,
                                    }
                                );
                return query.ToArray();
            }
        }
    }
}
