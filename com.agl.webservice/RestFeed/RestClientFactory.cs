using RestSharp;

namespace com.agl.webservice.RestFeed
{
    class RestClientFactory : IRestClientFactory
    {
        public RestClient Create(string endpointUrl) => new RestClient(endpointUrl);
    }
}
