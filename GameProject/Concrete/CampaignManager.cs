using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" "+"Adlı kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" "+"Adlı kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" "+"Adlı kampanya güncellendi.");
        }
    }
}
