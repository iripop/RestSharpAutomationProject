using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using TestProjectRS.Models;

namespace TestProjectRS
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
            Assert.Pass();
        }

        [Test]
        public void GetApiResult()
        {
            var url = EnvironmentUtils.GetVar("ApiUrl");
            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddParameter("id", "1");
            var response = client.Get(request);
            var obj = JObject.Parse(response.Content);
            //var deserialize = new JsonDeserializer();
            //var output = deserialize.Deserialize<Dictionary<string, string>>(response);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void PostApiResult()
        {
            var url = EnvironmentUtils.GetVar("ApiUrl");
            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddParameter("id", "1");
            var body = new Post { Body= "This is the test body",
            Title= "Post request", UserId=2};
            request.AddJsonBody(body);
            var response = client.Post(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        [Test]
        public void PostAsyncApiResult()
        {
            var url = EnvironmentUtils.GetVar("ApiUrl");
            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddParameter("id", "1");
            var body = new Post
            {
                Body = "This is the test body",
                Title = "Post request",
                UserId = 2
            };
            request.AddJsonBody(body);
            var response = client.Post(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        //private async Task<IRestResponse<T>> ExecureAsyncRequest<T>(RestClient client, IRestRequest restRequest) where T: class, new()
        //{
        //    var taskCompletionSource = new TaskCompletionSource<IRestResponse<T>>();

        //    var task= client.ExecuteAsync(restRequest, (restResponse, asyncHandle) =>
        //    {
        //        if (restResponse.ErrorException != null)
        //        {
        //            const string message = "Error retrieving response.";
        //            throw new ApplicationException(message, restResponse.ErrorException);
        //        }

        //        taskCompletionSource.SetResult(resp);
        //    });
        //    return await taskCompletionSource.Task;
        //}
    }
}