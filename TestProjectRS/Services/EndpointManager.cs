using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectRS.Services
{
    public static class EndpointManager
    {
        public static RestClient SetRequestEndpoint(RestClient restClient, string endpoint)
        {
            restClient = new RestClient(endpoint);
            return restClient;
        }
    }
}
