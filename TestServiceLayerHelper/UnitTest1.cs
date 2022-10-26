using B1SLayer;
using System.Diagnostics;

namespace TestServiceLayerHelper
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ServiceLayerHelper testServiceLayerHelper = new ServiceLayerHelper(
                "manager",
                "1234", "SBODEMOAU02",
                "https://192.168.10.230:50000/b1s/v2/"
                );
            var count = testServiceLayerHelper.Connection.Request("BusinessPartners").GetCountAsync().Result;
            Debug.WriteLine(count);


        }
    }
}