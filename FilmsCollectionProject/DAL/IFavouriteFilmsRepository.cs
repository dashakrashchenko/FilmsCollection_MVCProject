using System;
using System.Collections.Generic;
using System.Text;
using FilmsCollectionProject.Models;

namespace FilmsCollectionProject.DAL
{
    public interface IFavouriteFilmsRepository:IRepository<FavouriteFilms>
    {
        void AddToFavFilms(string filmname);
        void RemoveFromFavFilms(string filmname);
    }
}
