using System.Collections.Generic;
namespace PierresTracker.Models
{
  public class Vendor
  {
    //Starting with Vendor class to add orders to later.

    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public int Id { get; }


    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void Delete(int searchId)
{
    _instances.RemoveAll(vendor => vendor.Id == searchId);
}
  }
}