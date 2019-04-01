namespace burgerShack.Models
{
  abstract class Food
  {
    public string Name { get; set; }
    public float Price { get; set; }

    public Food(string name, float price)
    {
      Name = name;
      Price = price;
    }
  }
}