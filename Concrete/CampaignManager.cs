using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +" isimli kampanya tanımlandı");
          
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli kampanya sonlandırıldı!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli kampanya güncellendi");
        }
    }
}
