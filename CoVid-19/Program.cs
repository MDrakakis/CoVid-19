using System;

namespace CoVid_19
{
  class Program
  {
    static void Main()
    {
      Menu menu = new Menu();

      try
      {
        string userInput = menu.StartMenu();

        string country = menu.InputCheck(userInput);

        if (string.IsNullOrEmpty(country) || string.IsNullOrWhiteSpace(country))
          throw new Exception("Country not found !");

        CovidModel model = ApiHelper.GetCovidModel(country);

        menu.MainMenu(model);
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);
      }

      menu.CloseMenu();
    }
  }
}