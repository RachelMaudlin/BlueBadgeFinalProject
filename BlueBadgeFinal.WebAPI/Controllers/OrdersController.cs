﻿using BlueBadge.Models;
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
    public class OrdersController : ApiController
    {
       private OrdersService CreateOrdersService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var ordersService = new OrdersService(userId);
            return ordersService;
        }

        public IHttpActionResult Order(OrdersCreate orders)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOrdersService();

            if (!service.CreateOrders(orders))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Create(OrdersCreate orders)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOrdersService();

            if (!service.CreateOrders(orders))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            OrdersService ordersService = CreateOrdersService();
            var orders = ordersService.GetOrdersById(id);
            return Ok(orders);
        }

        public IHttpActionResult Put(OrdersEdit orders)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOrdersService();

            if (!service.UpdateOrders(orders))
                return InternalServerError();

            return Ok();
        }
    }
}