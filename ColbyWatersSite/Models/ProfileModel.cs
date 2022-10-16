using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ColbyWatersSite.Models
{
  public class ProfileModel
  {
    [Required]
    public string Name { get; set; }
    [Required]
    [Range(1, 10)]
    public int? Rating { get; set; }
    [Required]
    public string Comment { get; set; }

  }
}
