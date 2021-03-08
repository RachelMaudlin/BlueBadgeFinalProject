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
        public bool CreateOrders(OrdersCreate model)
        {
            var entity =
                new Orders()
                {
                    OrderId = model.OrderId,
                    CustomerId = model.CustomerId,
                    PaymentId = model.PaymentId,
                    OrderDate = model.OrderDate,
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
                    .Select(
                        e =>
                        new OrdersListItem
                        {
                            OrderId = e.OrderId,
                            CustomerId = e.CustomerId,
                            PaymentId = e.PaymentId,
                            OrderDate = e.OrderDate,
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
                    .Single(e => e.OrderId == id);
                return
                    new OrdersDetails
                    {
                        OrderId = entity.OrderId,
                        CustomerId = entity.CustomerId,
                        PaymentId = entity.PaymentId,
                        OrderDate = entity.OrderDate,
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
                    .Single(e => e.OrderId == model.OrderId);

                entity.CustomerId = model.CustomerId;
                entity.PaymentId = model.PaymentId;

                return ctx.SaveChanges() == 1;
            }
        }
        
        public bool DeleteOrders(int orderId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx

                    .Orders
                    .Single(e => e.OrderId == orderId);

                ctx.Orders.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
        
    }
}
