using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using CSHttpBaseLayer;
using CSConfigManager;
using Newtonsoft.Json.Linq;
using System.Windows.Forms; 

namespace CSHttpTransferLayer
{
    class ListItem
    {
        public string id;
        public string title;
    }

    class HttpTransferLayer
    {
        static public List<ListItem> GetList()
        {
            List<ListItem> list = new List<ListItem>();
            string szRet = HttpBaseLayer.Get(ConfigManager.GetDomain() + "index.php/dump/list_show", ConfigManager.GetUserAgent());
            //Trace.WriteLine("\n\n" + szRet + "\n\n");
            JArray arr = null;
            try
            {
                arr = JArray.Parse(szRet);
                foreach (JObject obj in arr)
                {
                    ListItem li = new ListItem();
                    li.id = obj["id"].ToString();
                    li.title = obj["title"].ToString();
                    list.Add(li);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(szRet);
            }
            return list;
        }

        static public byte[] GetItem(string id)
        {
            string szRet = HttpBaseLayer.Get(ConfigManager.GetDomain() + "index.php/dump/item_show/" + id, ConfigManager.GetUserAgent());
            try
            {
                return Convert.FromBase64String(szRet);
            }
            catch (System.Exception ex) 
            {
                MessageBox.Show(szRet);
            }

            return null;
            
        }

        static public bool DelItem(string id, out string ret_tip)
        {
            string szRet = HttpBaseLayer.Get(ConfigManager.GetDomain() + "index.php/dump/item_del/" + id, ConfigManager.GetUserAgent());
            try
            {
                JObject obj = JObject.Parse(szRet); 
                ret_tip = obj["ret_tip"].ToString();
                return Convert.ToBoolean(obj["ret_flag"]);
            }
            catch (System.Exception ex)
            {
                ret_tip = szRet;
            }
            return false;
        }

        static public bool AddItem(string title, string content, out string ret_tip)
        {
            StringBuilder sbParam = new StringBuilder();
            sbParam.Append("title=" + HttpUtility.UrlEncode(title));
            sbParam.Append("&content=" + HttpUtility.UrlEncode(content));

            string szRet = HttpBaseLayer.Post(ConfigManager.GetDomain() + "index.php/dump/item_add", sbParam.ToString(), ConfigManager.GetUserAgent());
            try
            {
                JObject obj = JObject.Parse(szRet);

                ret_tip = obj["ret_tip"].ToString();
                return Convert.ToBoolean(obj["ret_flag"]);
            }
            catch (System.Exception ex)
            {
                ret_tip = szRet;
            }
            return false;
        }
    }
}
