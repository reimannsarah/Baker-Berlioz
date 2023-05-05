using System;
using Baker.UserInterfaceModels;
using Baker.Models;

namespace Baker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to...");
      Console.WriteLine($"{Banner.Welcome}");
      Console.WriteLine("Place an order? (y/n)");
      string input = Console.ReadLine();
      if (input == "y")
      {
        Order();
      }
    }
    static void Order()
    {
      string item = ChooseItem();
      int amount = HowMany(item);
      GetTotal(item, amount);
      OrderMore();
    }
    static string ChooseItem()
    {
      Console.WriteLine("What sounds good?");
      Console.WriteLine("Bread");
      Console.WriteLine("Pastry");
      string choice = Console.ReadLine().ToLower();
      return choice;
    }
    static int HowMany(string selection)
    {
      if (selection == "bread")
      {
        Console.WriteLine("How many loaves would you like?");
        return int.Parse(Console.ReadLine());
      }
      else if (selection == "pastry")
      {
        Console.WriteLine("How many pastries would you like?");
        return int.Parse(Console.ReadLine());
      }
      else
      {
        Console.WriteLine("Please select from the available options");
        return HowMany(selection);
      }
    }
    static void GetTotal(string item, int amount)
    {
      if (item == "bread")
      {
        Bread newBreadOrder = new Bread(amount);
        Console.WriteLine($"Your total comes to ${newBreadOrder.CalculateTotal()}");
      }
      else if (item == "pastry")
      {
        Pastry newPastryOrder = new Pastry(amount);
        Console.WriteLine($"Your total comes to ${newPastryOrder.CalculateTotal()}");

      }
      }
      static void OrderMore()
      {
        Console.WriteLine("Would you like to order more? (y/n)");
        string orderMore = Console.ReadLine();
        if(orderMore == "y")
        {
          Order();
        }
    }
  }
}































//       string input = Console.ReadLine();
//       if (input == "y")
//       {
//         string choice = ChooseItem();
//         RingUpOrder(choice);
//         OrderMore();
//       }
//       else
//       {
//         Console.WriteLine("Goodbye!");
//       }
//       static string ChooseItem()
//       {
//         Console.WriteLine("What sounds good?");
//         Console.WriteLine("Bread");
//         Console.WriteLine("Pastry");
//         string answer = Console.ReadLine().ToLower();
//         return answer;
//       }
//       static int BreadOrder()
//       {
//         Console.WriteLine("How many loaves would you like?");
//         int breadOrder = int.Parse(Console.ReadLine());
//         Bread newBreadOrder = new Bread(breadOrder);
//         return newBreadOrder.CalculateTotal();
//       }
//       static int PastryOrder()
//       {
//         Console.WriteLine("How many pastries would you like?");
//         int pastryOrder = int.Parse(Console.ReadLine());
//         Pastry newPastryOrder = new Pastry(pastryOrder);
//         return newPastryOrder.CalculateTotal();
//       }
//       static void RingUpOrder(string choice)
//       {
//         if (choice == "bread")
//         {
//           Console.WriteLine($"Your total comes to: ${BreadOrder()}");
//         }
//         else if (choice == "pastry")
//         {
//           Console.WriteLine($"Your total comes to ${PastryOrder()}");
//         }
//       }
//       static void OrderMore()
//       {
//         Console.WriteLine("Would you like to order anything else? (y/n)");
//         string orderMore = Console.ReadLine();
//         if (orderMore == "y")
//         {
//           string moreItems = ChooseItem();
//         }
//       }