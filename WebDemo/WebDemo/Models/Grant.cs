using System;

namespace WebDemo.Models
{
  public class Grant : Entity
  {
    public decimal? Amount { get; set; }
    
    public DateTime? DueDate { get; set; }

    public string PortalGrantId { get; set; }
  }
}