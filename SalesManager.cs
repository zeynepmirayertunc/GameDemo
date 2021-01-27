using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class SalesManager : ISellService
    {
        public void SellCampaign(Customer customer, Campain campaign, Product product)
        {
            Console.WriteLine("Due to " + campaign.CampaignName + " campaign the product " + product.GameName + " was sold to the buyer "
                + customer.FirstName+ " at this price $" +campaign.CampaignPrice);
        }

        public void SellProduct(Customer customer,Product product)
        {
            Console.WriteLine("The product: " + product.GameName + " was sold to the buyer : " + customer.FirstName + " at the following price $: " + product.GamePrice);
        }
    }

}
