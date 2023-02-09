using FantasyFun.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application.Services
{
    public class MatchService : IMatchService
    {
        private IMatchRepository matchRepository;
        private IPlayerRepository playerRepository;

        public MatchService(IMatchRepository matchRepository, IPlayerRepository playerRepository)
        {
            this.matchRepository = matchRepository;
            this.playerRepository = playerRepository;
        }

        public Task<object> GetGoalScorersByMatchId(long matchId)
        {
            var getGoalScorers = matchRepository.GetGoalScorersByMatchId(matchId);

            // dla każdego player pobierasz imie z player Repository, mozesz uzyc istenijacej metody
            // i zwracasz potem już GoalsById które ma PlayerName (ViewModel finalny).

        }
    }
}
