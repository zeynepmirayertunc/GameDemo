using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CustomerheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
