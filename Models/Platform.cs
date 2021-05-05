using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
   public class Platform
   {
      [Key]
      public int Id { get; set; }
      [Required]
      public string Name { get; set; }
      public string LicenseKey { get; set; }
      public ICollection<Command> Commands { get; set; } = new List<Command>();

      public override string ToString()
      {
         var commandsString = "";
         foreach (var c in this.Commands)
         {
            commandsString += $"{c.ToString()}, ";
         }
         commandsString = commandsString.TrimEnd().TrimEnd(',');
         return $"Id: {this.Id}, Name: {this.Name}, LicenseKey: {this.LicenseKey}, Commands: {commandsString}";
      }
   }
}