using B1SLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace testProject;

[TestClass]
public class ServiceLayerHelperTest
{
    [TestMethod]
    public void Call()
    {
        string url = "https://192.168.10.230:50000/b1s/v2/";
        ServiceLayerHelper helper1 = new ServiceLayerHelper("manager", "1234", "SBODEMOAU02", url);

        ServiceLayerHelper helper2 = new ServiceLayerHelper("imran", "1234", "SBODEMOAU02", url);

        ServiceLayerHelper helper3 = new ServiceLayerHelper("umer", "1234", "SBODEMOAU02", url);

        var BPcountmanager = helper1.Connection.Request("BusinessPartners").GetCountAsync().Result;
        var BPcountimran = helper2.Connection.Request("BusinessPartners").GetCountAsync().Result;
        var BPcountimran2 = helper3.Connection.Request("BusinessPartners").GetCountAsync().Result;
        //serialize orders into json 
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(BPcountmanager);
        var json2 = Newtonsoft.Json.JsonConvert.SerializeObject(BPcountimran);
        var json3 = Newtonsoft.Json.JsonConvert.SerializeObject(BPcountimran2);
        Debug.WriteLine(json);
        Debug.WriteLine(json2);
        Debug.WriteLine(json3);

    }
}