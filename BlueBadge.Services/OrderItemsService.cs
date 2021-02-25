using BlueBadge.Data;
using BlueBadge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Services
{
    public class OrderItemsService
    {
        private readonly Guid _orderId;

        public OrderItemsService(Guid orderId)
        {
            _orderId = orderId;
        }

        public bool CreateOrderItems(OrderItemsCreate model)
        {
            var entity =
                new OrderItems()
                {
                    OrderId = _orderId,
                    CustomerId = model.CustomerId,
                    GameId = model.GameId,
                    PaymentId = model.PaymentId,
                    Quantity = model.Quantity,
                    OrderDate = model.OrderDate,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.OrderItems.Add(entity);
                return ctx.SaveChanges() == 1;
            }
  
        }

        public IEnumerable<OrderItemsListItem> GetOrderItems()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .OrderItems
                    .Where(e => e.OrderId == _orderId)
                    .Select(
                        e =>
                        new OrderItemsListItem
                        {
                           OrderId = e.OrderId,
                           CustomerId = e.CustomerId,
                           GameId = e.GameId,
                           PaymentId = e.PaymentId,
                           OrderDate = e.OrderDate,
                           ShipDate = e.ShipDate,
                        }
                  );

                return query.ToArray();
            }
        }

      public OrderItemsDetails GetOrderItemsById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .OrderItems
                    .Single(e => e.CustomerId == id && e.OrderId == _orderId);
                return
                    new OrderItemsDetails
                    {
                        OrderId = entity.OrderId,
                        CustomerId = entity.CustomerId,
                        GameId = entity.GameId,
                        PaymentId = entity.PaymentId,
                        Price = entity.Price,
                        Quantity = entity.Quantity,
                        OrderDate = entity.OrderDate,
                        ShipDate = entity.ShipDate
                    };
            }
        }

        public bool UpdateOrderItems(OrderItemsEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .OrderItems
                    .Single(e => e.OrderId == _orderId);
                entity.GameId = model.GameId;
                entity.PaymentId = model.PaymentId;
                entity.Quantity = model.Quantity;
                entity.OrderDate = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }


    }
}
