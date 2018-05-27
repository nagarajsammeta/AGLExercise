using RestSharp;

namespace com.agl.webservice.RestFeed
{
    interface IRestRequestFactory
    {
        RestRequest Create(string url, Method method);
    }
}
