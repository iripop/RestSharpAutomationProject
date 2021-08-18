using RestSharp;

namespace TestProjectRS.Services
{
    public abstract class ApiBase
    {
        public static RestClient RestClient;
        public static RestRequest RestRequest;
        public static IRestRequest IRestRequest;
        public static IRestResponse IRestResponse;

        public ApiBase(RestClient restClient, RestRequest restRequest, IRestRequest irestRequest, IRestResponse irestResponse)
        {
            RestClient = restClient;
            RestRequest = restRequest;
            IRestRequest = irestRequest;
            IRestResponse = irestResponse;
        }

        public ApiBase() { }
    }
}
