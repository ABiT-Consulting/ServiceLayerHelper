using B1SLayer;
using System;
namespace B1SLayer;
public class ServiceLayerHelper
{
    string key = string.Empty;
    SLConnection _connection ;
    protected string _url = "https://192.168.10.230:50000/b1s/v1/"; 
    string url {
        get{ return _url; }
    }
    private static  Dictionary<string , SLConnection> connections = new Dictionary<string ,SLConnection>();
    public   ServiceLayerHelper(string username,string password,string companyDB,string url )
    {   this._url = url;
        key = username + companyDB; 
        if (ServiceLayerHelper.connections.ContainsKey(key))
        { 
            _connection = ServiceLayerHelper.connections[key];
        }
        else
        {
            _connection = new SLConnection(url, companyDB,username, password);
            ServiceLayerHelper.connections.Add(key, _connection);
        } 
         
    }
    
    public SLConnection Connection
    {
        get
        { 
            return _connection;
        }
    }
}