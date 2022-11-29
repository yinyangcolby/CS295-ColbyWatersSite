using ColbyWatersSite.Controllers;
using ColbyWatersSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ColbyWatersSiteTests
{
  public class CommentTests
  {
    [Fact]
    public void CommentActionMethod_ReturnsAViewResult()
    {
      var rep = new Mock<IRepository<CommentModel>>();
      var controller = new HomeController(rep.Object);

      var result = controller.Forums();

      Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public void AddActionMethod_ReturnsAViewResult()
    {
      var rep = new Mock<IRepository<CommentModel>>();
      var controller = new HomeController(rep.Object);

      var result = controller.AddComment();

      Assert.IsType<ViewResult>(result);
    }
  }
}
