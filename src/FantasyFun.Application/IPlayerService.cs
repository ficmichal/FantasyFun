﻿using FantasyFun.Application.ViewModel;

namespace FantasyFun.Application
{
    public interface IPlayerService
    {
        public Task<IEnumerable<string>> GetPlayerByOverall(long overall);
        public Task<PlayerType> GetPlayerById(int id);
        public Task<long> Search(SearchPlayer search);
    }
}
