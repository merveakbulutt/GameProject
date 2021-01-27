using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { Id = 1, FirstName = "Gizem", LastName = "Tok", NationalityId = "1234567899", DateOfBirthYear =1995};
            Player player2 = new Player { Id = 2, FirstName = "Murat", LastName = "Işık", NationalityId = "1234867099", DateOfBirthYear =1998  };

            IPlayerService playerService = new PlayerManager(new PlayerCheckManager());
            IPlayerCheckService playerCheckService = new PlayerCheckManager();
            playerService.Add(player1);
            playerService.Add(player2);

            Game game1 = new Game { Id = 1, GameName = "FİFA", GamePrice = 300, GameReleaseYear = 2005 };
            Game game2 = new Game { Id = 2, GameName = "GTA", GamePrice = 200, GameReleaseYear = 2003};
            IGameService gameService = new GameManager();
            gameService.Sell(player2);
           
            ICampaignService campaignService = new CampaignManager();
            Campaign campaign1 = new Campaign { Id = 1, Name = "haftasonu indirimi", Discount = 0.2 };
            Campaign campaign2 = new Campaign { Id = 2, Name = "öğrenci indirimi", Discount = 0.5 };
            campaignService.Add(campaign2);
            campaignService.Delete(campaign1);

        }

        
    }
}
