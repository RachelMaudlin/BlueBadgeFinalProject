using BlueBadge.Data;
using BlueBadge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Services
{
    public class CustomerService
    {
        private readonly Guid _customerId;

        public CustomerService(Guid customerId)
        {
            _customerId = customerId;
        }

        public bool CreateNote(CustomerCreate model)
        {
            var entity =
                new Customer()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    ShippingAddress = model.ShippingAddress,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Customers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
