using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MvcApp.Models.Items
{
    public class Items
    {
        [Required]
        [NotNull]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public bool Agree {get; set;}
    }
}
