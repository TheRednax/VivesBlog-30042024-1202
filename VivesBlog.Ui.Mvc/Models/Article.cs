using System.ComponentModel.DataAnnotations;

namespace VivesBlog.Ui.Mvc.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        public int? AuthorId { get; set; }
        public Person? Author { get; set; }
        public DateTime PublishedDate { get; set; }

        [Required]
        public required string Description { get; set; }
        [Required]
        public required string Content { get; set; }
    }
}
