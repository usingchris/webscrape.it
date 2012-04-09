using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace webscrape.it.test.Helpers
{
    public class TestData
    {
        public string LoadTestData(string dataFilePath)
        {
            using (StreamReader sr = new StreamReader(dataFilePath))
            {
                string line;
                StringBuilder sbResults = new StringBuilder();
                while ((line = sr.ReadLine()) != null)
                {
                    sbResults.Append(line);
                }
                return sbResults.ToString();
            }
        }
    }
}
