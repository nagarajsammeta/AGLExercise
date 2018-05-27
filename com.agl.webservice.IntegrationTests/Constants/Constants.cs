using RestSharp;
using System.Collections.Generic;

namespace com.agl.webservice.IntegrationTests.Constants
{
    class Constants
    {
        public const string PEOPLESEARCH = "PeopleSearch";

        public static Dictionary<string, CommonConstants.Resource> AccountUriNMethods = new Dictionary<string, CommonConstants.Resource>()
        {
                   { PEOPLESEARCH , new CommonConstants.Resource{uri = "/people", method = Method.GET}},
        };
    }
}
