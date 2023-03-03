

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
  }
}