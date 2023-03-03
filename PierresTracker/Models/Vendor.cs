

namespace PierresTracker.Models
{
  public class Vendor
  {
    //Starting with Vendor class to add orders to later.
    public string Name { get; set; }
    public string Description { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
    }
  }
}