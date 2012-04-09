using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace webscrape.it.test
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void GetTagCollectionTestMethod()
        {
            Helpers.TestData helperTData = new Helpers.TestData();
            string testdata = helperTData.LoadTestData(ConfigurationManager.AppSettings["TestDataFilePath"]);

            webscrape.it.lib.HTML html = new lib.HTML();
            List<lib.Model.TagData> tagdatas = html.GetTagCollection(testdata, "TD");
        }
    }
}
