using System.ComponentModel.DataAnnotations;

namespace Basic_CRUD_App.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please select at least one language")]
        public List<string> ProgrammingLanguages { get; set; }
    }
}
