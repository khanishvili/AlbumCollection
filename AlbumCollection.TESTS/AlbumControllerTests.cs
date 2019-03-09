using System;
using AlbumCollection.Repositories;
using AlbumCollection.Controllers;
using Xunit;
using NSubstitute;
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
        public void Index_Sets_Model_To_All_Albums()
        {

        }
    }
}
