using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Buy(GameProduct gameProduct, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "was used");
            Console.WriteLine(gameProduct.ProductName+"sold for "+gameProduct.ProductPrice);
        }
    }
}
