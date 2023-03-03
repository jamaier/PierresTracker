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

    public Order(string orderTitle, string orderDescription, string orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
    }
  }
}