using System;
using System.Collections.Generic;
using System.Globalization;

namespace CoVid_19
{
  class Menu
  {
    readonly Countries countries = new Countries();

    // Display Welcome Menu
    public string StartMenu()
    {
      Console.WriteLine("");
      Console.Write("Please give a Country Name or Code: ");

      string userInput = Console.ReadLine().ToUpper();

      Console.Clear();

      return userInput;
    }

    // Display Main Menu
    public void MainMenu(CovidModel data)
    {
      string dateUpdated = $@"
 ====================================================== 
 ==          Date Updated: {data.Updated_At}       == 
 ======================================================";

      string countryDetails = $@"
 ====================================================== 
 ==                Country Details                   == 
 ====================================================== 
  - Country Name: {data.CountryName}                   
  - Country Code: {data.CountryCode}                   
  - Country Population: {data.CountryPopulation}       
  - Latitude: {data.Latitude}                          
  - Longtitude: {data.Longitude}                       
 ======================================================";

      string latestData = $@"
 ====================================================== 
 ==                   Latest Data                    == 
 ====================================================== 
  - Deaths: {data.LatestDeaths}                         
  - Confirmed: {data.LatestConfirmed}                   
  - Recovered: {data.LatestRecovered}                   
  - Critical: {data.LatestCritical}                     
 ======================================================";

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(dateUpdated);

      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine(countryDetails + latestData);
    }

    // Display Closing Menu
    public void CloseMenu()
    {
      Console.WriteLine("");
      Console.WriteLine("Press any key to exit...");
      Console.ReadLine();
    }

    // Check the user input
    public string InputCheck(string userInput)
    {
      List<RegionInfo> regionList = countries.GetCountries();
      string country = string.Empty;

      foreach (var item in regionList)
      {
        if (userInput.Equals(item.DisplayName.ToUpper()) || userInput.Equals(item.EnglishName.ToUpper()) || userInput.Equals(item.Name.ToUpper()))
        {
          country = item.Name;
          break;
        }
      }

      return country;
    }
  }
}