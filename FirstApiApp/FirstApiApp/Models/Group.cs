using System.ComponentModel.DataAnnotations;

namespace FirstApiApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
