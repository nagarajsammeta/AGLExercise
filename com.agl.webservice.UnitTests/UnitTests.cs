using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;

namespace com.agl.webservice.UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        string endpoint = ConfigurationManager.AppSettings["APIEndpointURL"];
        string Uri = ConfigurationManager.AppSettings["Uri"];
        IRestResponse response = null;
        public UnitTests()
        {
            response = Application.GetRestResponse(endpoint, Uri, Method.GET);
        }
        

        [Test]
        public void VerifyResponse_Status_ReturnsOK()
        {
            string actualStatus = response.StatusDescription;
            Assert.AreEqual("OK", actualStatus, "Actual Status Description is: "+ actualStatus);
        }

        [Test]
        public void VerifyResponse_Uri_ReturnsExpectedUri()
        {
            string actualResponseUri = response.ResponseUri.ToString();
            Assert.AreEqual(endpoint+Uri, actualResponseUri, "Actual Response Uri: " + actualResponseUri);
        }

        [Test]
        public void GetResponse_PeopleDetails_ReturnsData()
        {
            List<string> peopleDetails = Application.GetPeopleDetails(response.Content);
            if (!(peopleDetails.Count > 1))
                Assert.Fail("People Details are empty");
        }

        [Test]
        public void GetResponse_MaleOwnerDogDetails_ReturnsData()
        {
            List<string> peopleDetails = Application.GetMaleOwnerDogDetails(response.Content);
            if (!(peopleDetails.Count > 1))
                Assert.Fail("People Details are empty");
        }
    }
}
