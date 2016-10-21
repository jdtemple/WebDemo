using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace WebDemo.Models
{
  public class DemoContext : IdentityDbContext<ApplicationUser>
  {
    public DemoContext()
            : base("DemoContext", throwIfV1Schema: false)
    {
    }

    public virtual DbSet<Grant> Grants { get; set; }

    public static DemoContext Create()
    {
      return new DemoContext();
    }
  }
}