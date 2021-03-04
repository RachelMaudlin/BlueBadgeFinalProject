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


        public bool CreateOrderItems(OrderItemsCreate model)
        {
            var entity =
                new OrderItems()
                {
                    OrderItemId = model.OrderItemId,
                    OrderId = model.OrderID,
                    GameId = model.GameId,
                    Quantity = model.Quantity,
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
                    .Select(
                        e =>
                        new OrderItemsListItem
                        {
                           OrderItemId = e.OrderItemId,
                           OrderId = e.OrderId,
                           GameId = e.GameId,
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
                    .Single(e => e.OrderItemId == id);
                return
                    new OrderItemsDetails
                    {
                        OrderId = entity.OrderId,
                        GameId = entity.GameId,
                        Price = entity.Price,
                        Quantity = entity.Quantity,
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
                    .Single(e => e.OrderItemId == model.OrderItemId);
                //entity.GameId = model.GameId;
                entity.Quantity = model.Quantity;

                return ctx.SaveChanges() == 1;
            }
        }


    }
}
