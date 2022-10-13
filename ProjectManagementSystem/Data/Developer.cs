using System.ComponentModel.DataAnnotations;

namespace ProjectManagementSystem.Data
{
    public class Developer
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, Enter a Ctegory first")]
        public string Project { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public float Experience { get; set; }
    }
}
