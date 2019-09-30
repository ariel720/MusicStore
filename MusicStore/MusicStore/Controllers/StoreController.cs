using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return Ok("test from index");
        }

        // GET: /Store/Browse?genre=Disco
        public IActionResult Browse(string genre)
        {
           
            return View();
        }

        // GET: /Store/Details/5
        public IActionResult Details(int id)
        {


            return View();
        }
         public IActionResult Albums()
        {
            var albums = new List<Album>();
            for(int i = 0; i<10; i++)
            {
                albums.Add(new Album { Name = "album_"+i.ToString(), Artist = "test"+i.ToString() });

            }
            return View(albums);
        }

    }
}