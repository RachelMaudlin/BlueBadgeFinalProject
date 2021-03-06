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
    public class OrderItemsController : ApiController
    {
        
        private OrderItemsService CreateOrderItemsService()
        {
            var orderItemsService = new OrderItemsService();
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

        public IHttpActionResult Get(int id)
        {
            OrderItemsService orderItemsService = CreateOrderItemsService();
            var orderItems = orderItemsService.GetOrderItemsById(id);
            return Ok(orderItems);
        }

        public IHttpActionResult Put(OrderItemsEdit orderItems)
        {
            if(!ModelState.IsValid)
               return BadRequest(ModelState);

            var service = CreateOrderItemsService();

            if (!service.UpdateOrderItems(orderItems))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateOrderItemsService();

            if (!service.DeleteOrderItems(id))
                return InternalServerError();

            return Ok();
        }
    }
}
