
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient(new KPSPublicSoapClient.EndpointConfiguration());
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateofBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
                
            
        }
    }
}
