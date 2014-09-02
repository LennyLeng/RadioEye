using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace CSConfigManager
{
    class ConfigManager
    {
        public static string GetUserAgent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");
            XmlNode useragent = doc.SelectSingleNode("appconfig/useragent");
            if (useragent != null)
            {
                return useragent.InnerText;
            }
            else
            {
                return "";
            }
        }

        public static string GetDomain()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");
            XmlNode domain = doc.SelectSingleNode("appconfig/domain");
            if (domain != null)
            {
                if (domain.InnerText.EndsWith("/"))
                {
                    return domain.InnerText;
                }
                else
                {
                    return domain.InnerText + "/";
                }
                
            }
            else
            {
                return "";
            }
        }
    }
}
