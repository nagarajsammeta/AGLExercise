using RestSharp;

namespace com.agl.webservice.IntegrationTests.Constants
{
    class CommonConstants
    {
        //Controller Names Constants
        public const string AGLSERVICE = "AGLWebService";

        //Scenario Context Constants
        public const string SC_JSONRESPONSE = "JsonResponse";
        public const string SC_CONTROLLER = "Controller";
        public const string SC_RESOURCE = "Resource";

        public class Resource
        {
            public string uri { get; set; }
            public Method method { get; set; }
        }

    }
}

