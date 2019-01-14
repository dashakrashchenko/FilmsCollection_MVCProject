using System;
using System.Collections.Generic;
using System.Text;
using FilmsCollectionProject.Models;

namespace FilmsCollectionProject.DAL
{
    public interface IFilmsRepository: IRepository<Films>
    {
        IEnumerable<Films> GetAllFilmsByFilmmaker(string fullname);
        Films GetInfoAboutFilm(string filmname);
        IEnumerable<Films> GetAllFilmsByGenre(string genre);
        IEnumerable<Films> GetAllFilmsByReleaseDate();
        IEnumerable<Films> GetBestFilmsByImdb();
    }
}
