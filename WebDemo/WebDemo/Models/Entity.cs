using System.ComponentModel.DataAnnotations;

namespace WebDemo.Models
{
  public class Entity
  {
    [Key]
    public virtual int Id { get; set; }
  }
}
