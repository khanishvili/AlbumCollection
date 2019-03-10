using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Repositories;
using AlbumCollection.Models;


namespace AlbumCollection.Controllers
{
    public class AlbumController : Controller
    {
        private IAlbumRepository repo;

        public AlbumController(IAlbumRepository repo)
        {
            this.repo = repo;
        }

        public ViewResult Index()
        {
           var  albumModel = repo.GetAll();
            return View(albumModel);
        }
    }
}