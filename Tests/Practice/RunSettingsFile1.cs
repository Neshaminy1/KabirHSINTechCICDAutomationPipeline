using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSINTechCICDAutomationPipeline.Tests.Practice
{

    [TestClass]
    public class RunSettingsFile1
    {
        private string googleurl;
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void RunSettingFile_Method()
        {
            googleurl = TestContext.Properties["GoogleURL"].ToString();
            Console.WriteLine(googleurl);
        }

        
    }
}
