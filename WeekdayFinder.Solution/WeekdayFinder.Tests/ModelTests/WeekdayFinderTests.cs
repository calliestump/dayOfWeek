using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayFindersTests
  {
    [TestMethod]
    public void WeekdayFinders_InputtedValidDate_Date()
    {
      WeekdayFinders Date = new WeekdayFinders("2020", "12", "9");
      Assert.AreEqual("2020", Date.Year);
      Assert.AreEqual("12", Date.Month);
      Assert.AreEqual("9", Date.Day);
    }
  }
}