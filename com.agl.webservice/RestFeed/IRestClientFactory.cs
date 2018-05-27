using RestSharp;

namespace com.agl.webservice.RestFeed
{
    interface IRestClientFactory
    {
        RestClient Create(string endpointUrl);
    }
}
