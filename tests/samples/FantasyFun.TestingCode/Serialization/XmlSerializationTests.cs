using FantasyFun.API.Requests;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xunit;

namespace FantasyFun.TestingCode.Serialization
{
    public class XmlSerializationTests
    {
        [Fact]
        public void XmlTests()
        {
            var goalAsString = "<goal><value><comment>n</comment><stats><goals>1</goals><shoton>1</shoton></stats><event_incident_typefk>393</event_incident_typefk><coordinates><value>26</value><value>62</value></coordinates><elapsed>10</elapsed><player2>41326</player2><subtype>shot</subtype><player1>79253</player1><sortorder>3</sortorder><team>8529</team><id>3788503</id><n>257</n><type>goal</type><goal_type>n</goal_type></value><value><comment>n</comment><stats><goals>1</goals><shoton>1</shoton></stats><event_incident_typefk>393</event_incident_typefk><coordinates><value>19</value><value>7</value></coordinates><elapsed>18</elapsed><player2>30991</player2><subtype>shot</subtype><player1>40165</player1><sortorder>2</sortorder><team>8636</team><id>3788625</id><n>239</n><type>goal</type><goal_type>n</goal_type></value><value><comment>n</comment><stats><goals>1</goals><shoton>1</shoton></stats><event_incident_typefk>80</event_incident_typefk><coordinates><value>25</value><value>64</value></coordinates><elapsed>29</elapsed><subtype>shot</subtype><player1>71768</player1><sortorder>6</sortorder><team>8529</team><id>3788804</id><n>245</n><type>goal</type><goal_type>n</goal_type></value><value><comment>n</comment><stats><goals>1</goals><shoton>1</shoton></stats><event_incident_typefk>393</event_incident_typefk><coordinates><value>23</value><value>63</value></coordinates><elapsed>35</elapsed><player2>172644</player2><subtype>shot</subtype><player1>71768</player1><sortorder>0</sortorder><team>8529</team><id>3788894</id><n>263</n><type>goal</type><goal_type>n</goal_type></value><value><comment>npm</comment><event_incident_typefk>348</event_incident_typefk><coordinates><value>23</value><value>62</value></coordinates><elapsed>44</elapsed><subtype>saved_back_into_play</subtype><player1>41326</player1><sortorder>0</sortorder><team>8529</team><id>3789061</id><n>94</n><type>goal</type><goal_type>npm</goal_type></value><value><comment>n</comment><stats><goals>1</goals><shoton>1</shoton></stats><event_incident_typefk>80</event_incident_typefk><coordinates><value>22</value><value>64</value></coordinates><elapsed>44</elapsed><subtype>shot</subtype><player1>71768</player1><sortorder>3</sortorder><team>8529</team><id>3789077</id><n>319</n><type>goal</type><goal_type>n</goal_type></value></goal>";
            var xmlSerializer = new XmlSerializer(typeof(Goal));

            object result;
            using (TextReader reader = new StringReader(goalAsString))
            {
                result = xmlSerializer.Deserialize(reader);
            }

            var goal = result as Goal;
        }

        [XmlRoot("goal")]
        public class Goal
        {
            [XmlElement("value")]
            public List<Value> Value { get; set; }
        }

        public class Value
        {
            [XmlElement("team")]
            public long Team { get; set; }

            [XmlElement("id")]
            public long Id { get; set; }

            [XmlElement("goal_type")]
            public string GoalType {get; set; }
        }

        //ViewModel końcowy
        public class GoalsInMatch
        {
            public List<GoalInMatch> WhoScored { get; set; } = new List<GoalInMatch>();
        }

        public class GoalInMatch
        {
            public string PlayerName { get; set; }
            public int NumberOfGoals { get; set; }
        }
    }
}