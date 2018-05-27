using com.agl.webservice.RestFeed;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agl.webservice.Controller
{
    class ConsumeService
    {
        private IRestClientFactory restClientFactory;
        private IRestRequestFactory restRequestFactory;

        //Dependency Injection - Type is - Constructor Injection
        #region Constructor Injection
        public ConsumeService(IRestClientFactory restClientFactory, IRestRequestFactory restRequestFactory)
        {
            this.restClientFactory = restClientFactory;
            this.restRequestFactory = restRequestFactory;
        }
        #endregion

        #region ConsumeService
        public IRestResponse GetResponse(string endpoint, string Uri, Method method)
        {
            var restClient = restClientFactory.Create(endpoint);
            var restRequest = restRequestFactory.Create(Uri, method);
            var response = restClient.Execute(restRequest);
            return response;
        }
        #endregion
    }
}
