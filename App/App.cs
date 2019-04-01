using System;
using System.Collections.Generic;

namespace burgerShack.Models
{
  class App
  {
    List<Entree> Menu { get; set; }
    List<Side> SideMenu { get; set; }
    public void InitializeData()
    {
      Menu = new List<Entree>();
      SideMenu = new List<Side>();
      Entree BigMac = new Entree("Big Macintosh", 6.25f, 1);
      Entree Dqp = new Entree("Double Quarter Flounder", 5.89f, 2);
      Entree Chick = new Entree("McLicken", 4.90f, 3);
      Entree Nugs = new Entree("Licken Nuggets", 5.85f, 4);
      Side Fries = new Side("Fries", 2.10f, "small");
      Drink Coke = new Drink("Coke", 1.25f, "small", true);
      Menu.Add(BigMac);
      Menu.Add(Dqp);
      Menu.Add(Chick);
      Menu.Add(Nugs);
      SideMenu.Add(Fries);
      SideMenu.Add(Coke);
    }
    public void Run()
    {
      InitializeData();
      string activeEntree;
      System.Console.WriteLine("Welcome to SlackDonald's");
      Menu.ForEach(i =>
      {
        System.Console.WriteLine(i.ComboNumber + ": " + i.Name + " - $" + i.Price.ToString("n2"));
      });
      System.Console.WriteLine(@"
Please select a menu item or view the (s)ides
");

      string userInput = Console.ReadLine();
      evaluateSelection(userInput);
    }

    private void evaluateSelection(string userInput)
    {
      int userSelection;
      if (Int32.TryParse(userInput, out userSelection) && Int32.Parse(userInput) <= Menu.Count)
      {
        System.Console.WriteLine("Select (y) to make that a meal by adding fries and drink to your order?");
        string mealChoice = Console.ReadLine();
        customerSelectMeal(mealChoice);
      }
      else if (userInput == "s")
      {
        showSideMenu();
      }
      else
      {
        System.Console.WriteLine("Bad input");
      }
    }

    private void showSideMenu()
    {
      Console.Clear();
      int sideItemIndex = 1;
      SideMenu.ForEach(s =>
      {
        System.Console.WriteLine(sideItemIndex++ + ": " + s.Name + " - $" + s.Price.ToString("n2"));
      });
    }

    private void customerSelectMeal(string mealChoice)
    {
      if (mealChoice == "y")
      {
        makeMeal();
      }
      else
      {
        System.Console.WriteLine("Your order of _______ is ready. Your total is _______");
      }
    }

    private void makeMeal()
    {
      // int total = Entree.Price + 2.35
    }

    public App()
    {

    }
  }
}