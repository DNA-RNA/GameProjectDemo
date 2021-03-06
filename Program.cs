using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Campaign campaign1 = new Campaign {CampaignName="Şubat sonu %15 indirimi" , CampaignType="İndirim" };
            Campaign campaign2 = new Campaign { CampaignName = "Sevgililer günü çekilişi", CampaignType = "Çekiliş" };
           
            Console.WriteLine("<<<<<<<<<<Kampanyalar>>>>>>>>>>");
            CampaignManager campaignmanger = new CampaignManager();
            campaignmanger.Add(campaign1);
            campaignmanger.Add(campaign2);
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<<Oyuncular>>>>>>>>>>");
            PlayerManager player1 = new PlayerManager(new MernisServiceAdapter());
            player1.Add(new Entities.Player { DateOfBirth = new DateTime(2001, 4, 1), FirstName = "Mary", LastName = "Blood", NationalityId = "12345678" });

            PlayerManager player2 = new PlayerManager(new MernisServiceAdapter());
            player2.Add(new Entities.Player { DateOfBirth = new DateTime(1993, 9, 9), FirstName = "Frank", LastName = "Underwood", NationalityId = "12345678" });
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<<Oyunlar>>>>>>>>>");
            GameProduct game1 = new GameProduct() { GameName = "Total War", GameType = "Strateji", GamePrice = 70 };
            GameProduct game2 = new GameProduct() { GameName = "Battlefield 1", GameType = "Savaş", GamePrice = 300 };
            GameProduct game3 = new GameProduct() { GameName = "MotoGP", GameType = "Yarış", GamePrice = 100 };
            GameProduct[] gameProducts = new GameProduct[] { game1, game2, game3 };
            foreach (var product in gameProducts)
            {
                Console.WriteLine("\t Oyunun ismi: " + product.GameName + "---> " + "Oyunun türü: " + product.GameType + "---> " + "Oyunun fiyatı: " + product.GamePrice);
            }
            Console.WriteLine();
            SaleManager sale = new SaleManager();
            
            sale.SaleOperation(campaign2, game1);
            
        
        }
    }
}
