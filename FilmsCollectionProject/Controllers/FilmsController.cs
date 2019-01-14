using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilmsCollectionProject.Models;
using FilmsCollectionProject.DAL;

namespace FilmsCollectionProject.Controllers
{
    public class FilmsController : Controller
    {
        private IFilmsRepository filmsrepo;
        private IFilmmakersRepository makerrepo;
        public FilmsController()
        {
            this.filmsrepo = new FilmsRepository(new FilmsCollectionDBContext());
        }

        public ViewResult Index()
        {
            ViewBag.FilmsByImdb = filmsrepo.GetBestFilmsByImdb().Take(7);
            ViewBag.NewFilms = filmsrepo.GetAll().OrderByDescending(d => d.Releasedate).Take(7);
            return View();
        }

        public ViewResult FilmInfo(string filmname)
        {
            makerrepo = new FilmmakersRepository(new FilmsCollectionDBContext());

            Films film = filmsrepo.GetInfoAboutFilm(filmname);
            ViewBag.MakerName = makerrepo.GetAll().Where(s => s.IdFilmmaker == film.IdMaker).Select((s) => { var fullname = s.Firstname + ' ' + s.Lastname; return fullname; } ).First();
            ViewBag.FilmsByThisFilmmaker = filmsrepo.GetAll().Where(s => s.IdMaker == film.IdMaker).OrderByDescending(s => s.ImdbScore).Take(5);
            var a = filmsrepo.GetAll().Where(s => s.IdMaker == film.IdMaker).OrderByDescending(s => s.ImdbScore).Take(5);
            return View(film);
        }
        
    }
}