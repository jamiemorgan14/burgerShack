using System;

namespace burgerShack.Models
{
  class Entree : Food
  {
    public int ComboNumber { get; set; }
    public Entree(string name, float price, int comboNumber) : base(name, price)
    {
      ComboNumber = comboNumber;
    }

  }
}