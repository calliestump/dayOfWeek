using System;
using WeekdayFinder.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter a year");
    string year = Console.ReadLine();
    Console.WriteLine("Please enter a month");
    string month = Console.ReadLine();
    Console.WriteLine("Please enter a day");
    string day = Console.ReadLine();
    WeekdayFinders Date = new WeekdayFinders(year, month, day);
    Console.WriteLine("View your date below : ");
    Console.WriteLine(Date.Year + ", " + Date.Month + ", " + Date.Day);
    DateTime dateValue = new DateTime(int.Parse(Date.Year), int.Parse(Date.Month), int.Parse(Date.Day));
    Console.WriteLine("The day of the week you've entered is : ");
    Console.WriteLine(dateValue.ToString("dddd"));
  }
}