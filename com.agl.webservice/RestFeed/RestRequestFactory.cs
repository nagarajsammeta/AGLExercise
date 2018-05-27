using RestSharp;

namespace com.agl.webservice.RestFeed
{
    class RestRequestFactory : IRestRequestFactory
    {
        public RestRequest Create(string url, Method method) => new RestRequest(url, method);
    }
}
