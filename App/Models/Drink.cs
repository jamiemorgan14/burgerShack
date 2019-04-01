namespace burgerShack.Models
{
  class Drink : Side
  {
    public bool Ice { get; set; }
    public Drink(string name, float price, string size, bool ice) : base(name, price, size)
    {
      Ice = ice;
    }
  }
}