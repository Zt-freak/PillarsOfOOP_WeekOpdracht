using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Entities;

namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<IMovie> GetAll();
        IMovie GetById(int id);
        IMovie GetByName(string name);
        void Add(IMovie movie);
        void Update(IMovie movie);
        void Delete(int id);
    }
}
