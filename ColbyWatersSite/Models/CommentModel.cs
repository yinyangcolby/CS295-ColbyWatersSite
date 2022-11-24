using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColbyWatersSite.Models
{
  public class CommentModel
  {
    [Key]
    public int CommentId { get; set; }

    [Required(ErrorMessage = "Please enter your name.")]
    [MaxLength(50, ErrorMessage = "Name can't be longer than 50 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter a rating.")]
    [Range(1, 10, ErrorMessage = "Value must be between 1 and 10.")]
    public int? Rating { get; set; }

    [Required(ErrorMessage = "Please enter a comment.")]
    public string Comment { get; set; }

    public string Date { get; set; }
  }
}
