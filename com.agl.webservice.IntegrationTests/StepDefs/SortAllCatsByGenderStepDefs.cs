using com.agl.webservice.IntegrationTests.Constants;
using com.agl.webservice.IntegrationTests.Model;
using System;
using TechTalk.SpecFlow;

namespace com.agl.webservice.IntegrationTests.StepDefs
{
    [Binding]
    class SortAllCatsByGenderStepDefs
    {
        [Given(@"Controller ""(.*)"" resource ""(.*)""")]
        public void GivenControllerResource(string controller, string resourceName)
        {
            ScenarioContext.Current[CommonConstants.SC_CONTROLLER] = controller;
            ScenarioContext.Current[CommonConstants.SC_RESOURCE] = resourceName;
        }

        [Then(@"Send request to controller")]
        public void ThenSendRequestToController()
        {
            string controller = ScenarioContext.Current[CommonConstants.SC_CONTROLLER].ToString();
            string resourceName = ScenarioContext.Current[CommonConstants.SC_RESOURCE].ToString();

            switch (controller)
            {
                case CommonConstants.AGLSERVICE:
                    AGLController.Execute();
                    break;
                default:
                    throw new Exception("Could not find the resource name");
            }
        }

        [Then(@"I output all the ""(.*)"" Cats in alphabetical order")]
        public void ThenIOutputAllTheCatsInAlphabeticalOrder(string gender)
        {
            string jsonResp = ScenarioContext.Current[CommonConstants.SC_JSONRESPONSE].ToString();
            if (gender.Equals("Male"))
            {
                Console.WriteLine(gender + ".");
                AGLController.GetMaleOwnerCats(jsonResp);
            }
            else if(gender.Equals("Female"))
            {
                Console.WriteLine(gender + ".");
                AGLController.GetFemaleOwnerCats(jsonResp);
            }
            
        }
    }
}
