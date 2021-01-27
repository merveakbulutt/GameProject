using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Sell(Player player)
        {
            Console.WriteLine("oyun satış yapıldı." + " " + player.FirstName);
        }

        public void SellWithCampaign(Player player, Campaign campaign)
        {
            Console.WriteLine("kampanyalı fiyattan satış yapıldı.");
        }
    }
}
