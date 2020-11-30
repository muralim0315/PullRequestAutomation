using System;
using RestSharp;

namespace PULLRequestAPIsTestAssignment.Context
{
    class Settings
    {
        public Uri BaseUrl { get; set; }
        public IRestResponse Response { get; set; }
        public IRestRequest Request { get; set; }
        public IRestClient RestClient {get;set; } = new RestClient();
    }
}
