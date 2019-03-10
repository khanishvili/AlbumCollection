using System;
using AlbumCollection.Repositories;
using AlbumCollection.Controllers;
using Xunit;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AlbumCollection.Models;

namespace AlbumCollection.TESTS
{
    public class AlbumControllerTests
    {
        IAlbumRepository repo;
        AlbumController under_Test;
        public AlbumControllerTests()
        {
            repo = Substitute.For<IAlbumRepository>();
            under_Test = new AlbumController(repo);
        }

        [Fact]
        public void Album_Controller_Has_A_View()
        {
            var model = under_Test.Index();
            Assert.IsType<ViewResult>(model);
        }
        [Fact]
        public void Index_Sets_Model_To_All_Albums()
        {
            var expectedModel = new List<Album>();
            
        }
    }
}
