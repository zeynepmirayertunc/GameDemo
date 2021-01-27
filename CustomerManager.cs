using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is deleted from the system");
        }

        public void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Customer is saved to the system " + customer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer informaion is updated" +customer.FirstName);
        }
    }
}
