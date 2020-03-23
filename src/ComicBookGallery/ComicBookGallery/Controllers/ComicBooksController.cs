using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "Spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p> Final issue!</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan",
                "Pencils: Bob",
                "Inks: John",
                "Colors: Dan",
                "Letters: Dan"

            };

            return View();


          
        }
    }
}