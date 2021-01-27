using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
   public  interface ISellService
    {
        void SellProduct(Customer customer,Product product);
        void SellCampaign(Customer customer,Campain campaign,Product product);
    }
}
