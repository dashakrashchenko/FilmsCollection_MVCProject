using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsCollectionProject.DAL
{
    public interface IUnitOfWork: IDisposable 
    {
        IFilmmakersRepository Filmmakers { get; }
        int Complete();
    }
}
