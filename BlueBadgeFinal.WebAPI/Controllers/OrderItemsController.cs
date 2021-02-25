using BlueBadge.Models;
using BlueBadge.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlueBadgeFinal.WebAPI.Controllers
{
    [Authorize]
    public class OrderItemsController : ApiController
    {
        
        private OrderItemsService CreateOrderItemsService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var orderItemsService = new OrderItemsService(userId);
            return orderItemsService;
        }

        public IHttpActionResult Get()
        {
            OrderItemsService orderItemsService = CreateOrderItemsService();
            var orderItems = orderItemsService.GetOrderItems();
            return Ok(orderItems);
        }

        public IHttpActionResult Create(OrderItemsCreate orderItems)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOrderItemsService();

            if (!service.CreateOrderItems(orderItems))
                return InternalServerError();

            return Ok();
        }
    }
}
