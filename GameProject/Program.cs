using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Campaigns");
            Campaign campaign1 = new Campaign { CampaignName = "Mother's Day", CampaignType = "Discount1" };
            Campaign campaign2 = new Campaign { CampaignName = "Father's Day", CampaignType = "Discount3" };
            Campaign campaign3 = new Campaign { CampaignName = "Valentine's Day", CampaignType = "Discount3" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign3);
            Console.WriteLine("---------------------------------------");

            GamerManager gamer1 = new GamerManager(new MernisServiceAdapter());
            gamer1.Register(new Gamer { DateOfBirthday = new DateTime(1999, 4, 21), FirstName = "Büşra", LastName = "Bulut", NationalityId = "18580220777" });

            Console.WriteLine("Games");
            GameProduct game1 = new GameProduct() { Id = 1, ProductName = "Pubg", ProductPrice = 60 };
            GameProduct game2 = new GameProduct() { Id = 2, ProductName = "Lol", ProductPrice = 25 };
            GameProduct game3 = new GameProduct() { Id = 1, ProductName = "GTA", ProductPrice = 54 };

            GameSaleManager sale = new GameSaleManager();

            sale.Buy(game1, campaign3);




        }
    }
}
