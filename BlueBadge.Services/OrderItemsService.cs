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
        private readonly Guid _userId;

        public OrderItemsService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateOrderItems(OrderItemsCreate model)
        {
            var entity =
                new OrderItems()
                {
                    CustomerId = _userId,
                    OrderId = model.OrderID,
                    PaymentId = model.PaymentId,
                    Quantity = model.Quantity,
                    CreatedUtc = DateTimeOffset.Now
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
                    .Where(e => e.CustomerId == _userId)
                    .Select(
                        e =>
                        new OrderItemsListItem
                        {
                            OrderId = e.OrderId,
                            GameId = e.GameId,
                            PaymentId = e.PaymentId,
                            CreatedUtc = e.CreatedUtc,
                        }
                  );

                return query.ToArray();
            }
        }
    }
}
