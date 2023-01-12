namespace Factory.Models
{
  public class EngineerMachine
  {
    public int StudentMachineId { get; set;}
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }
  }
}