
namespace Models
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
}

