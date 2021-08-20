using System;
using System.Collections.Generic;
using System.Linq;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using WeekOpdrachtDependencyInjection.Business.Repositories;

namespace WeekOpdrachtDependencyInjection.Business
{
    public class MovieService
    {
        private readonly IMovieRepository _repository;
        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }

        public IMovie GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IMovie GetByName(string name)
        {
            return _repository.GetByName(name);
        }

        public void SeedDatabase()
        {
            if (_repository.GetAll().ToList().Count == 0)
            {
                _repository.Add(new Movie { Title = "Jaws", ReleaseDate = new DateTime(1975, 1, 1) });
                _repository.Add(new Movie { Title = "Luca", ReleaseDate = new DateTime(2021, 1, 1)});
                _repository.Add(new Movie { Title = "Kill Bill", ReleaseDate = new DateTime(2003, 1, 1) });
            }
        }
    }
}
