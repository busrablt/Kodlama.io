using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Entry(Campaign campaign)
        {
            Console.WriteLine("New campaign entered:"+campaign.CampaignType + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("New campaign deleted:" + campaign.CampaignType + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("New campaign updated:" + campaign.CampaignType + campaign.CampaignName);
        }
    }
}
