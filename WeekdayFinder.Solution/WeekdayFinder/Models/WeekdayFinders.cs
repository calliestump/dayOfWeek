using System;

namespace WeekdayFinder.Models
{
  public class WeekdayFinders
  {
    public string Year { get; set; }
    public string Month { get; set; }
    public string Day { get; set; }

    public WeekdayFinders(string year, string month, string day)
    {
      Year = year; 
      Month = month; 
      Day = day; 
    }
  }
}