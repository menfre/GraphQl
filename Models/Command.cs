using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
   public class Command
   {
      [Key]
      public int Id { get; set; }
      [Required]
      public string HowTo { get; set; }
      [Required]
      public string CommandLine { get; set; }
      [Required]
      public int PlatformId { get; set; }
      public Platform Platform { get; set; }

      public override string ToString()
      {
         return $"Id: {this.Id}, HowTo: {this.HowTo}, CommandLine: {this.CommandLine}, PlatformId: :{this.PlatformId}, Platform.Name: {Platform?.Name}";
      }
   }
}