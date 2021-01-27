using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
