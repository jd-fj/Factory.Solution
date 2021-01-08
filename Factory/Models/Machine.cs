using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<Licenses>();
    }

    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public ICollection<Licenses> Engineers { get; set; }
  }
}