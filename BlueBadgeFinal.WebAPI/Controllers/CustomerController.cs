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
    public class CustomerController : ApiController
    {
        private CustomerService CreateCustomerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var CustomerService = new CustomerService(userId);
            return CustomerService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            CustomerService customerService = CreateCustomerService();
            var customers = customerService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpPost]
        public IHttpActionResult Post(CustomerCreate customer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCustomerService();

            if (!service.CreateCustomer(customer))
                return InternalServerError();

            return Ok();
        }
    }
}
