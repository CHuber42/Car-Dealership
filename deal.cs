using System;
using System.Collections.Generic;

namespace DealerShip
{

public class Car
{

  private string _MakeModel;
  private int _Price;
  private int _Miles;
  private string _Message;


    public static string MakeSound()
    {
      string sound = "honk!";
      return "the car is mad it said" + " " + sound;
    }

  public Car(string makeModel, int price, int miles, string message)
  {
    _MakeModel = makeModel;

    _Price = price;

    _Miles = miles;

    _Message = message;

  }

  public void SetMakeModel(string model)
  {
    _MakeModel = model;
  }
  public string GetMakeModel()
  {
    return _MakeModel;
  }
  public void SetMessage(string message)
  {
    _Message = message;
  }
  public string GetMessage()
  {
    return _Message;
  }

  public bool WorthBuying(int maxPrice, int maxMilage)
  {
    return (_Price < maxPrice && _Miles < maxMilage);
  }
}
public class Program
{

  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792,"this car is dope");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "this car is rad");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "this car smells weird");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "this car is old");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };



    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum mileage: ");
    string stringMaxMileage = Console.ReadLine();
    int maxMilage = int.Parse(stringMaxMileage);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars) 
    {
      if (automobile.WorthBuying(maxPrice, maxMilage))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel() + " " + automobile.GetMessage());
      Console.WriteLine(Car.MakeSound());
    }
    Console.WriteLine("Actually, these are geese, not cars");
  }

  }
}