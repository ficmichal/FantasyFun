using FantasyFun.DAL.Settings;
using FantasyFun.DAL.ViewModel;
using FantasyFun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyFun.DAL.Repositories;

namespace FantasyFun.Application
{
    internal class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<IEnumerable<string>> GetPlayerByOverall(long overall)
        {
            var anyPlayersWithOverall = await _playerRepository.GetPlayerByOverall(overall);

            return anyPlayersWithOverall;
        }
        
        public async Task<IEnumerable<PlayerType>> GetPlayerById(int id)
        {
            var allPlayers = await _playerRepository.GetPlayerById(id);
            return allPlayers;
        }
    }

}
