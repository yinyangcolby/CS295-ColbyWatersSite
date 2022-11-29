using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColbyWatersSite.Models
{
  public class CommentDBContext : DbContext
  {
    public CommentDBContext(DbContextOptions<CommentDBContext> options) : base(options) { }

    public DbSet<CommentModel> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<CommentModel>().HasData(
          new CommentModel
          {
            CommentId = 1,
            Name = "anonymous",
            Rating = 7,
            Comment = "testing testing...",
            Date = "11/11/2022"
          }
      );
    }
  }
}
