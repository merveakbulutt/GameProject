using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " "+ "Adlı oyuncu eklendi");
            }
            else
            {
                throw new Exception("Not a valid person!");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + "oyuncu silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + "oyuncu güncellendi.");
        }

      
    }
}
