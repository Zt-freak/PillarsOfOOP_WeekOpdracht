using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Context;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesContext _context;

        public MovieRepository(MoviesContext context)
        {
            _context = context;
        }

        public void Add(IMovie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMovie> GetAll()
        {
            return _context.Movies;
        }

        public IMovie GetById(int id)
        {
            return _context.Movies.Find(id);
        }

        public IMovie GetByName(string name)
        {
            return _context.Movies.FirstOrDefault(m => m.Title == name);
        }

        public void Update(IMovie movie)
        {
            throw new NotImplementedException();
        }
    }
}
