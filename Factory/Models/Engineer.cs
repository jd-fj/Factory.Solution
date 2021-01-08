using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<Licenses>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public virtual ICollection<Licenses> Machines { get; }
  }
}