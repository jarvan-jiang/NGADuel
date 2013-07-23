using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace NGADuel
{
    public static class CommonUsing
    {
        public static string GetDuelType(int? type)
        {
            XDocument xml = XDocument.Load(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Config/Configs.xml");
            return xml.Element("DuelType").Elements().Single(x => x.Attribute("value").Value == type.ToString()).Value;
        }

        public static string GetServerName(int? server)
        {
            XDocument xml = XDocument.Load(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Config/Configs.xml");
            return xml.Element("DuelServer").Elements().Single(x => x.Attribute("value").Value == server.ToString()).Value;
        }
    }
}