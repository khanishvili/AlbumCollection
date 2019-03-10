using System;
using AlbumCollection.Repositories;
using AlbumCollection.Controllers;
using Xunit;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AlbumCollection.Models;

namespace AlbumCollection.Tests
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
        public void Album_Controller_Has_View()
        {
            var model = under_Test.Index();
            Assert.IsType<ViewResult>(model);
        }
        [Fact]
        public void Index_Controller_Returns_A_View()
        {
            var model = under_Test.Index();

            Assert.IsType<ViewResult>(model);
        }
        [Fact]
        public void Index_Sets_Model_To_All_Albums()
        {             
            var expectedModel = new List<Album>();            
            repo.GetAll().Returns(expectedModel);
            
            var actualModel = under_Test.Index().Model;
            
            Assert.Equal(expectedModel, actualModel);
        }
        [Fact]
        public void Details_Returns_A_View()
        {
            var model = under_Test.Details(1);

            Assert.IsType<ViewResult>(model);
        }
        [Fact]
        public void Details_Sets_Model_To_Correct_Album()
        {
            var expectedId = 3;
            var expectedModel = new Album();
            repo.GetById(expectedId).Returns(expectedModel);

            var result = under_Test.Details(expectedId);
            var acttualModel = (Album)result.Model;

            Assert.Equal(expectedModel, acttualModel);
        }

    }
}
