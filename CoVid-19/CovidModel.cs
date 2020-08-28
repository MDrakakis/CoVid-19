namespace CoVid_19
{
  class CovidModel
  {
    #region Properties

    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string CountryName { get; set; }
    public string CountryCode { get; set; }
    public string CountryPopulation { get; set; }
    public string Updated_At { get; set; }
    public string TodayDeaths { get; set; }
    public string TodayConfirmed { get; set; }
    public string LatestDeaths { get; set; }
    public string LatestConfirmed { get; set; }
    public string LatestRecovered { get; set; }
    public string LatestCritical { get; set; }
    public string LatestCalcDeath_rate { get; set; }
    public string LatestCalcRecovery_rate { get; set; }
    public string Recovered_vs_Death_Ratio { get; set; }
    public string Cases_Per_Million_Population { get; set; }
    public string TimeLineUpdated_At { get; set; }
    public string TimeLineDate { get; set; }
    public string TimeLineDeaths { get; set; }
    public string TimeLineConfirmed { get; set; }
    public string TimeLineActive { get; set; }
    public string TimeLineRecovered { get; set; }
    public string TimeLineNew_Confirmed { get; set; }
    public string TimeLineNew_Recovered { get; set; }
    public string TimeLineNew_Deaths { get; set; }
    public string TimeLineIs_In_Progress { get; set; }

    #endregion Properties
  }
}