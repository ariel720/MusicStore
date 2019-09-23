using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return Ok("test");
        }

        // GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
        + genre);

            return message;
        }

        // GET: /Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }
    }
}