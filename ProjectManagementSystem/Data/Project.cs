using System.ComponentModel.DataAnnotations;

namespace ProjectManagementSystem.Data
{
    public class Project 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTimeOffset StartDate { get; set; }
    }
}
