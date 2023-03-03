using System.Collections.Generic;
using System.Linq;

namespace PierresTracker.Models
{
  public class Vendor
  {
    //Starting with Vendor class to add orders to later.

    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public int Id { get; }
    public List<Order> Orders = new List<Order>() { };

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    // public static void RemoveVendor(int id)
    // {
    //   _instances.RemoveAll(vendor => vendor.Id == id);
    // }
    // public void DeleteAllOrders(int searchId)
    // {
    //   Orders.RemoveAll(order => order.Id == searchId);
    // }
    // public static void RemoveOrder(int searchId)
    // {
    //   _instances.RemoveAll(order => order.Id == searchId);
    // }
    public void DeleteAllOrders()
    {
      Orders.Clear();
    }

  }
}