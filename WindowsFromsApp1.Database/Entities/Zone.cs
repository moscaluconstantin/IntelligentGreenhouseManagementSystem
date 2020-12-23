namespace WindowsFromsApp1.Database.Entities
{
     public class Zone
     {
          public int Id { get; set; }
          public string ZoneName { get; set; }
          public int StrategyId {get;set;}
          public virtual Strategy Strategy { get; set; }
     }


}


