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
            var goalAsString = "<goal>\r\n\t<value>\r\n\t\t<comment>n</comment>\r\n\t\t<stats>\r\n\t\t\t<goals>1</goals>\r\n\t\t\t<shoton>1</shoton>\r\n\t\t</stats>\r\n\t\t<event_incident_typefk>130</event_incident_typefk>\r\n\t\t<coordinates>\r\n\t\t\t<value>4</value>\r\n\t\t\t<value>58</value>\r\n\t\t</coordinates>\r\n\t\t<elapsed>75</elapsed>\r\n\t\t<subtype>direct_freekick</subtype>\r\n\t\t<player1>172899</player1>\r\n\t\t<sortorder>0</sortorder>\r\n\t\t<team>9882</team>\r\n\t\t<id>3792597</id>\r\n\t\t<n>295</n>\r\n\t\t<type>goal</type>\r\n\t\t<goal_type>n</goal_type>\r\n\t</value>\r\n</goal>";
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
            public Value Value { get; set; }
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
    }
}