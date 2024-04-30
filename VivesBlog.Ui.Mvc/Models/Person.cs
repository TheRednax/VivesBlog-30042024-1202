using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VivesBlog.Ui.Mvc.Models
{
    public class Person
    {
        public int Id { get; set; }

        [DisplayName("First name")]
        [Required]
        public required string FirstName { get; set; }

        [DisplayName("Last name")]
        [Required]
        public required string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public IList<Article> Articles { get; set; } = new List<Article>();
    }
}
