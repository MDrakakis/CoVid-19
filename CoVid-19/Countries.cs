using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CoVid_19
{
  class Countries
  {
    /// <summary>
    /// Get Countries Codes and Countries Names 
    /// </summary>
    /// <returns>List<RegionInfo></returns>
    public List<RegionInfo> GetCountries()
    {
      List<RegionInfo> countries = new List<RegionInfo>();
      try
      {
        foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
        {
          RegionInfo country = new RegionInfo(culture.LCID);

          if (countries.Where(p => p.Name == country.Name).Count() == 0)
          {
            countries.Add(country);
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);
      }
      return countries.OrderBy(p => p.EnglishName).ToList();
    }
  }
}
