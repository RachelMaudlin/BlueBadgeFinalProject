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
        

        public OrdersService(Guid orderId)
        {
            _orderId = orderId;
        }

      
     
        public bool CreateOrders(OrdersCreate model)
        {
            var entity =
                new Orders()
                {
                    OrderId = _orderId,
                    CustomerId = model.CustomerId,
                    PaymentId = model.PaymentId,
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
                    .Where(e => e.OrderId == _orderId)
                    .Select(
                        e =>
                        new OrdersListItem
                        {
                            OrderId = e.OrderId,
                            CustomerId = e.CustomerId,
                            PaymentId = e.PaymentId,
                            OrderDate = e.OrderDate,
                            ShipDate = e.ShipDate,
                        }
                    );

                return query.ToArray();
            }
        }
        
        public OrdersDetails GetOrdersById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Orders
                    .Single(e => e.CustomerId == id && e.OrderId == _orderId);
                return
                    new OrdersDetails
                    {
                        OrderId = entity.OrderId,
                        CustomerId = entity.CustomerId,
                        PaymentId = entity.PaymentId,
                        OrderDate = entity.OrderDate,
                        ShipDate = entity.OrderDate
                    };
            }
        }


        public bool UpdateOrders(OrdersEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Orders
                    .Single(e => e.OrderId == _orderId);

                entity.CustomerId = model.CustomerId;
                entity.PaymentId = model.PaymentId;

                return ctx.SaveChanges() == 1;
            }
        }
        
        
    }
}
