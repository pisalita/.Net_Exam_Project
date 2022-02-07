using System.ComponentModel.DataAnnotations;

namespace cbsStudents.Models.Entities;

public class Post
{
    public int Id { get; set; }


    [Required(ErrorMessage = "Please fill out title")]
    [MinLength(3, ErrorMessage = "Minimum 3 characters")]
    public string? Title { get; set; }

    [Required]
    [MinLength(10)]
    public string? Text { get; set; }

    [DataType(DataType.Date)]
    public DateTime Created { get; set; }

    public PostStatus Status { get; set; }

}


