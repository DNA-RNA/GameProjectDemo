using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public  class SaleManager : ISaleService
    {
        public void SaleOperation(Campaign campaign,GameProduct gameProduct)
        {
            gameProduct.GamePrice = (23 * gameProduct.GamePrice) / 20;

            Console.WriteLine( "Müşteri, "  + campaign.CampaignName +  " kampanyasını kullandı" );
            Console.WriteLine("Müşterinin kredi kartı bilgileri kontrol ediliyor");
            Console.WriteLine("Oyunu kampanya ile " + gameProduct.GamePrice + " TL'ye aldı");
            
           
        }
    }
}
