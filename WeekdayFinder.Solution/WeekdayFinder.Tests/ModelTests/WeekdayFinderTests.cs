using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayFindersTests
  {
    WeekdayFinders Date = new WeekdayFinders("2020", "12", "9");
    [TestMethod]
    public void WeekdayFinders_InputtedValidDate_Date()
    {
      Assert.AreEqual("2020", Date.Year);
      Assert.AreEqual("12", Date.Month);
      Assert.AreEqual("9", Date.Day);
    }
    [TestMethod]
    public void WeekdayFinders_Weekday_DayofWeek()
    {
      DateTime dateValue = new DateTime(int.Parse(Date.Year), int.Parse(Date.Month), int.Parse(Date.Day));      
      Assert.AreEqual("Wednesday", dateValue.ToString("dddd"));
    }
  }
}