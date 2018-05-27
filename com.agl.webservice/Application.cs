using com.agl.webservice.Controller;
using com.agl.webservice.RestFeed;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace com.agl.webservice
{
    public class Application
    {
        #region GetRestResponse
        public static IRestResponse GetRestResponse(string endpoint, string Uri, Method method)
        {
            IRestClientFactory restClient = new RestClientFactory();
            IRestRequestFactory restRequest = new RestRequestFactory();
            ConsumeService consume = new ConsumeService(restClient, restRequest);
            var response = consume.GetResponse(endpoint, Uri, method);
            Console.WriteLine(response.Content);
            return response;
        }
        #endregion

        #region JsonDeserialize
        public static dynamic JsonDeserialize(string respJson)
        {
            dynamic jsonData = JsonConvert.DeserializeObject(respJson);
            return jsonData;
        }
        #endregion

        #region GetPeopleDetails
        public static List<String> GetPeopleDetails(string respJson)
        {
            List<string> names = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                names.Add(jsonData[i].name.ToString());
            }
            return names;
        }
        #endregion

        #region GetMaleDetails
        public static List<String> GetMaleDetails(string respJson)
        {
            List<string> maleNames = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                if (jsonData[i].gender == "Male")
                {
                    maleNames.Add(jsonData[i].name.ToString());
                }
            }
            return maleNames;
        }
        #endregion

        #region GetFemaleDetails
        public List<String> GetFemaleDetails(string respJson)
        {
            List<string> femaleNames = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                if (jsonData[i].gender == "Female")
                {
                    femaleNames.Add(jsonData[i].name.ToString());
                }
            }
            return femaleNames;
        }
        #endregion

        #region GetAllDogDetails
        public static List<String> GetDogDetails(string respJson)
        {
            List<string> dogNames = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                if (jsonData[i].pets != null)
                {
                    for (int j = 0; j < jsonData[i].pets.Count; j++)
                    {
                        if (jsonData[i].pets[j].type == "Dog")
                        {
                            dogNames.Add(jsonData[i].pets[j].name.ToString());
                        }
                    }
                }
            }
            return dogNames;
        }
        #endregion

        #region GetAllCatDetails
        public static List<String> GetCatDetails(string respJson)
        {
            List<string> catNames = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                if (jsonData[i].pets != null)
                {
                    for (int j = 0; j < jsonData[i].pets.Count; j++)
                    {
                        if (jsonData[i].pets[j].type == "Cat")
                        {
                            catNames.Add(jsonData[i].pets[j].name.ToString());
                        }
                    }
                }
            }
            return catNames;
        }
        #endregion

        #region GetMaleOwnerDogDetails
        public static List<String> GetMaleOwnerDogDetails(string respJson)
        {
            List<string> maleOwnerDogNames = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                if (jsonData[i].gender == "Male")
                {
                    if (jsonData[i].pets != null)
                    {
                        for (int j = 0; j < jsonData[i].pets.Count; j++)
                        {
                            if (jsonData[i].pets[j].type == "Dog")
                            {
                                maleOwnerDogNames.Add(jsonData[i].pets[j].name.ToString());
                            }
                        }
                    }
                }
            }
            return maleOwnerDogNames;
        }
        #endregion

        #region GetMaleOwnerCatDetails
        public static List<String> GetMaleOwnerCatDetails(string respJson)
        {
            List<string> maleOwnerCatNames = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                if (jsonData[i].gender == "Male")
                {
                    if (jsonData[i].pets != null)
                    {
                        for (int j = 0; j < jsonData[i].pets.Count; j++)
                        {
                            if (jsonData[i].pets[j].type == "Cat")
                            {
                                maleOwnerCatNames.Add(jsonData[i].pets[j].name.ToString());
                            }
                        }
                    }
                }
            }
            return maleOwnerCatNames;
        }
        #endregion

        #region GetFemaleOwnerDogDetails
        public static List<String> GetFemaleOwnerDogDetails(string respJson)
        {
            List<string> femaleOwnerDogNames = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                if (jsonData[i].gender == "Female")
                {
                    if (jsonData[i].pets != null)
                    {
                        for (int j = 0; j < jsonData[i].pets.Count; j++)
                        {
                            if (jsonData[i].pets[j].type == "Dog")
                            {
                                femaleOwnerDogNames.Add(jsonData[i].pets[j].name.ToString());
                            }
                        }
                    }
                }
            }
            return femaleOwnerDogNames;
        }
        #endregion

        #region GetFemaleOwnerCatDetails
        public static List<String> GetFemaleOwnerCatDetails(string respJson)
        {
            List<string> femaleOwnerCatNames = new List<string>();
            dynamic jsonData = JsonDeserialize(respJson);

            for (int i = 0; i < jsonData.Count; i++)
            {
                if (jsonData[i].gender == "Female")
                {
                    if (jsonData[i].pets != null)
                    {
                        for (int j = 0; j < jsonData[i].pets.Count; j++)
                        {
                            if (jsonData[i].pets[j].type == "Cat")
                            {
                                femaleOwnerCatNames.Add(jsonData[i].pets[j].name.ToString());
                            }
                        }
                    }
                }
            }
            return femaleOwnerCatNames;
        }
        #endregion
    }
}
