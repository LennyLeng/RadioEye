using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSRegexStringLayer
{
    class RegexStringLayer
    {
        static public string[] GetSubString(string strContent, string strRegex)
        {
            Match mc = Regex.Match(strContent.Replace("\n", ""), strRegex, RegexOptions.IgnoreCase);
            int count = mc.Groups.Count;
            string[] strSubTemp = new string[count];
            for (int i = 0; i < count; i++)
            {
                strSubTemp[i] = mc.Groups[i + 1].Value;
            }
            return strSubTemp;
        }

        static public bool CheckMatch(string strContent, string strRegex)
        {
            return Regex.IsMatch(strContent, strRegex);
        }
    }
}
