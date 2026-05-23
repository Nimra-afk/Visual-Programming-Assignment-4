using System.ComponentModel.DataAnnotations;

namespace VP_LAB_Assignment4.Models
{
    public class TodoTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;
    }
}
