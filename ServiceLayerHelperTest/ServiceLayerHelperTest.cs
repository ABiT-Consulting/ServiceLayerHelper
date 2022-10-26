using B1SLayer;
using System.Diagnostics;

namespace ServiceLayerHelperTest
{
    [TestClass]
    public class ServiceLayerHelperTest
    {
        [TestMethod]
        public void count_customers_forusers()
        {
            ServiceLayerHelper testServiceLayerHelpermanager = new ServiceLayerHelper(
                "manager",
                "1234", "SBODEMOAU02",
                "https://192.168.10.230:50000/b1s/v2/"
                );
            var countmanager = testServiceLayerHelpermanager.Connection.Request("BusinessPartners").GetCountAsync().Result;
            Debug.WriteLine(countmanager);
            ServiceLayerHelper testServiceLayerHelperimran = new ServiceLayerHelper(
                "imran",
                "1234", "SBODEMOAU02",
                "https://192.168.10.230:50000/b1s/v2/"
                );
            var countimran = testServiceLayerHelperimran.Connection.Request("BusinessPartners").GetCountAsync().Result;
            Debug.WriteLine(countimran);
            ServiceLayerHelper testServiceLayerHelperuer = new ServiceLayerHelper(
               "umer",
               "1234", "SBODEMOAU02",
               "https://192.168.10.230:50000/b1s/v2/"
               );
            var countumer = testServiceLayerHelperuer.Connection.Request("BusinessPartners").GetCountAsync().Result;
            Debug.WriteLine(countumer);
        }
    }
}