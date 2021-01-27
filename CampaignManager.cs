using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campain campain)
        {
            Console.WriteLine("Campaign has been deleted");
        }

        public void NewCampaign(Campain campain)
        {
            Console.WriteLine("For this product: " + campain.CampaignName + " The Campaign has been added");
        }

        public void UpdateCampaign(Campain campain, Product product)
        {
            
            Console.WriteLine("For this product: "+campain.CampaignName+" The campaign has been updated ");
        }
    }
}
