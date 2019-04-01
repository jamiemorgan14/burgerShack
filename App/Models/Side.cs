namespace burgerShack.Models
{
  class Side : Food
  {
    public string Size { get; set; }
    public Side(string name, float price, string size) : base(name, price)
    {
      Size = size;
    }
  }
}