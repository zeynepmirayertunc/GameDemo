using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
