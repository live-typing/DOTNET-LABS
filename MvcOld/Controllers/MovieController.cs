using MvcOld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOld.Controllers
{
    public class MoviesController : Controller
    {
        public static List<Movies> film = new List<Movies>();
        // GET: Movies
        [Route("/showMovies")]
        [HttpGet]
        public ActionResult GetAllMovies()
        {
            if (film.Count == 0)
            {
                film.Add(new Movies() { MovieId = 1, Name = "PS-1", Director = "Mani Ratnam", Boxoffice = 1000 });
            }
            return View(film);
        }
        [HttpGet]
        public ActionResult AddNewMovie()
        {
            return View(new Movies());
        }
        [HttpPost]
        public ActionResult AddNewMovie(Movies pFilm)
        {
            film.Add(pFilm);
            return View("GetAllMovies", film);
        }
        [HttpGet]
        public ActionResult AddNewAjaxMovie()
        {
            return View(new Movies());
        }
        [HttpPost]
        public ActionResult AddNewAjaxMovie(Movies pFilm)
        {
            film.Add(pFilm);
            return PartialView("GetAllMovies", film);
        }
        [HttpGet]
        public ActionResult UpdateMovie(int code)
        {
            Movies find = film.Where(single => single.MovieId == code).ToList().FirstOrDefault();
            return View(find);
        }
        [HttpPost]
        public ActionResult UpdateMovie(int code, Movies updatedFilm)
        {
            Movies find = film.Where(single => single.MovieId == updatedFilm.MovieId).ToList().FirstOrDefault();
            find.Name = updatedFilm.Name;
            find.Director = updatedFilm.Director;
            find.Boxoffice = updatedFilm.Boxoffice;

            return View("GetAllMovies", film);
        }

        [HttpGet]
        public ActionResult DeleteMovie(int code)
        {
            Movies find = film.Where(single => single.MovieId == code).ToList().FirstOrDefault();
            return View(find);

        }
        [HttpPost]
        public ActionResult DeleteMovie(int code, Movies tobedeleted)
        {
            Movies find = film.Where(single => single.MovieId == code).ToList().FirstOrDefault();
            film.Remove(find);
            return View("GetAllMovies", film);
        }

    }
}

