using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ICampaignService
    {
        void NewCampaign(Campain campain);
        void DeleteCampaign(Campain campain);
        void UpdateCampaign(Campain campain, Product product);

    }
}
