using com.agl.webservice.IntegrationTests.Constants;
using System;
using System.Collections.Generic;
using System.Configuration;
using TechTalk.SpecFlow;

namespace com.agl.webservice.IntegrationTests.Model
{
    class AGLController
    {
        #region GetResponse
        internal static void Execute()
        {
            var uri = Constants.Constants.AccountUriNMethods[Constants.Constants.PEOPLESEARCH].uri;
            var method = Constants.Constants.AccountUriNMethods[Constants.Constants.PEOPLESEARCH].method;
            string endpointURL = ConfigurationManager.AppSettings["APIEndpointURL"];

            var response = Application.GetRestResponse(endpointURL, uri, method);
            string respJson = response.Content;
            ScenarioContext.Current[CommonConstants.SC_JSONRESPONSE] = respJson;
        }
        #endregion

        #region GetMaleOwnerCats
        internal static void GetMaleOwnerCats(string jsonResp)
        {
            List<string> maleCats = Application.GetMaleOwnerCatDetails(jsonResp);
            maleCats.Sort();
            foreach (string s in maleCats)
                Console.WriteLine(s);
        }
        #endregion

        #region GetFemaleOwnerCats
        internal static void GetFemaleOwnerCats(string jsonResp)
        {
            List<string> femaleCats = Application.GetFemaleOwnerCatDetails(jsonResp);
            femaleCats.Sort();
            foreach (string s in femaleCats)
                Console.WriteLine(s);
        }
        #endregion
    }
}
