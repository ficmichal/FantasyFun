﻿namespace FantasyFun.DAL.Models
{
    public class Player
    {
        Player()
        {
            Players = new HashSet<Player_Attribute>();
        }

        public int Id { get; set; }
        public int ApiId { get; set; }
        public string Name { get; set; }
        public int FifaApiId { get; set; }
        public  DateTime Birthday { get; set; }

        public virtual ICollection<Player_Attribute> Players { get; set; }
    }
}
