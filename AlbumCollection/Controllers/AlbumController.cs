using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    public class AlbumController : Controller
    {
        private IAlbumRepository repo;

        public AlbumController(IAlbumRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var model = repo.GetAll();
            return View(model);
        }
    }
}