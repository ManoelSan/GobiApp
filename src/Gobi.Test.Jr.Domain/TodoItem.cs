using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Gobi.Test.Jr.Domain
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool Completed { get; set; }
        public string Description { get; set; }
    }
}