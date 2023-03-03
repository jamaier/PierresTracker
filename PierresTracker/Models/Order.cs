using System.Collections.Generic;
using PierresTracker.Models;

namespace PierresTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; } // Change to int when implementing depending on time
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderTitle, string orderDescription, string orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

        public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}