using System;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class Movie : IMovie
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public DateTime ReleaseDate {  get; set; }
    }
}
