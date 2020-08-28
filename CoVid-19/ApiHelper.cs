using System;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CoVid_19
{
  class ApiHelper
  {
    public static CovidModel GetCovidModel(string countryCode)
    {
      Uri baseUrl = new Uri($"http://corona-api.com/countries/{countryCode}");

      RestClient client = new RestClient(baseUrl);
      RestRequest request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

      var response = client.Execute<CovidModel>(request);
      var data = JObject.Parse(response.Content.Normalize());

      CovidModel model = new CovidModel()
      {
        Latitude = (string)data["data"]["coordinates"]["latitude"],
        Longitude = (string)data["data"]["coordinates"]["longitude"],

        CountryName = (string)data["data"]["name"],
        CountryCode = (string)data["data"]["code"],
        CountryPopulation = (string)data["data"]["population"],
        Updated_At = (string)data["data"]["updated_at"],

        LatestDeaths = (string)data["data"]["latest_data"]["deaths"],
        LatestConfirmed = (string)data["data"]["latest_data"]["confirmed"],
        LatestRecovered = (string)data["data"]["latest_data"]["recovered"],
        LatestCritical = (string)data["data"]["latest_data"]["critical"]
      };

      return model;
    }
  }
}