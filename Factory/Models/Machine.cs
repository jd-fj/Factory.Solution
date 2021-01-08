using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<Licences>();
    }

    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public ICollection<Licences> Engineers { get; set; }
  }
}