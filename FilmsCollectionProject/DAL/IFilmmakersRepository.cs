using System;
using System.Collections.Generic;
using System.Text;
using FilmsCollectionProject.Models;

namespace FilmsCollectionProject.DAL
{
    public interface IFilmmakersRepository: IRepository<Filmmakers>
    {
        Filmmakers GetInfoAboutFilmmaker(string fullname);
        IEnumerable<Filmmakers> GetFilmmakerByGenre(string genre);
        IEnumerable<Filmmakers> GetFilmmakerbyAward(string award);
    }
}
