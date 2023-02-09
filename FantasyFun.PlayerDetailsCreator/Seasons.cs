namespace FantasyFun.PlayerDetailsCreator
{
    public class Seasons
    {
        public static List<Season> AllSeasons = new List<Season>
        {
            new(1, new(2007, 01, 01), new(2007, 08, 01)),
            new(2, new(2007, 08, 01), new(2008, 01, 01)),
            new(3, new(2008, 01, 01), new(2008, 08, 01)),
            new(4, new(2008, 08, 01), new(2009, 01, 01)),
            new(5, new(2009, 01, 01), new(2009, 08, 01)),
            new(6, new(2009, 08, 01), new(2010, 01, 01)),
            new(7, new(2010, 01, 01), new(2010, 08, 01)),
            new(8, new(2010, 08, 01), new(2011, 01, 01)),
            new(9, new(2011, 01, 01), new(2011, 08, 01)),
            new(10, new(2011, 08, 01), new(2012, 01, 01)),
            new(11, new(2012, 01, 01), new(2012, 08, 01)),
            new(12, new(2012, 08, 01), new(2013, 01, 01)),
            new(13, new(2013, 01, 01), new(2013, 08, 01)),
            new(14, new(2013, 08, 01), new(2014, 01, 01)),
            new(15, new(2014, 01, 01), new(2014, 08, 01)),
            new(16, new(2014, 08, 01), new(2015, 01, 01)),
            new(17, new(2015, 01, 01), new(2015, 08, 01)),
            new(18, new(2015, 08, 01), new(2016, 01, 01)),
            new(19, new(2016, 01, 01), new(2016, 08, 01)),
            new(20, new(2016, 08, 01), new(2017, 01, 01)),
        };

        public static int GetSeason(DateTime time)
        {
            return AllSeasons.FirstOrDefault(season => season.IsIn(time))?.Id ?? 0;
        }
    }
}
