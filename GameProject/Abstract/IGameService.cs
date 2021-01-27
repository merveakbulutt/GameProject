using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
     public interface IGameService
    {
        void Sell(Player player);
        void SellWithCampaign(Player player, Campaign campaign);


    }
}
