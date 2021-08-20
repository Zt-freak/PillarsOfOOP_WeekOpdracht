using System;

namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
    public interface IMovie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}