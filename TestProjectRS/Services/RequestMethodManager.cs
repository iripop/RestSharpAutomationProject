using RestSharp;

namespace TestProjectRS
{
    public static class RequestMethodManager
    {
        public static RestRequest SetRequestMethod(RestRequest restRequest, Method method, DataFormat dataFormat)
        {
            restRequest = new RestRequest(method)
            {
                RequestFormat = dataFormat
            };
            return restRequest;
        }
    }
}
