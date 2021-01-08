using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<Licences>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public virtual ICollection<Licences> Machines { get; }
  }
}