using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webscrape.it.lib.Model;
using System.Text.RegularExpressions;

namespace webscrape.it.lib
{
    public class HTML
    {
        public List<TagData> GetTagCollection(string source, string tag)
        {
            List<TagData> tagdatas = new List<TagData>();

            MatchCollection m1 = Regex.Matches(source, @"(<" + tag + ".*?</" + tag + ">)", RegexOptions.Singleline);
            int ordercount = 0;
            foreach (Match m in m1)
            {
                ordercount++;
                string valuehtml = m.Groups[1].Value;
                string valuetext = Regex.Replace(valuehtml, @"\s*<.*?>\s*", "", RegexOptions.Singleline).Replace("&nbsp;", "").Trim();
                tagdatas.Add(new TagData { ContentHTML = valuehtml, ContentText = valuetext, Order = ordercount });
            }

            return tagdatas;
        }
    }
}
