using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        private ComicBookRepository _commicBookRepository = null;

        public ComicBookController()
        {
            _commicBookRepository = new ComicBookRepository();
        }
        public ActionResult Details(int? id)
        {
            if (id == null) return HttpNotFound();

            ComicBook book = _commicBookRepository.GetComicBook((int)id);
            
            return View(book);
        }

        public ActionResult Index()
        {
            

            return View(_commicBookRepository.GetComicBooks());
        }
    }
}