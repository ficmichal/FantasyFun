using FantasyFun.API.Models;
using System.Linq.Expressions;

namespace FantasyFun.API.ViewModel.Filters
{
    public class PlayerFilters
    {
        public long Overall { get; set; }

        public string Name { get; set; }

        public Expression<Func<Player_Attribute, bool>> FilterByName()
        {
            return pa => string.IsNullOrEmpty(Name) 
                ? true 
                : pa.Player.Name.Contains(Name);
        }
    }
}
