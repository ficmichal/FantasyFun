using FantasyFun.DAL.Models;
using FantasyFun.DAL.Repositories;
using FantasyFun.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application.UnitTests
{

    public class StubPlayerRepository : IPlayerRepository
    {

        public Task<PlayerType> GetPlayerById(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<string>> GetPlayerByOverall(long overall)
        {
            var objectsList = new List<string>()
            {
            new string("Aaron Appindangoye")
             };

            var objectsList2 = new List<string>()
            {
            new string("Mikołaj Wojewoda")
             };

            if (overall == 1)
            {
                return await Task.FromResult(objectsList);
            }
            else
            {
                return await Task.FromResult(objectsList2);
            }
                
        }
    }
}
