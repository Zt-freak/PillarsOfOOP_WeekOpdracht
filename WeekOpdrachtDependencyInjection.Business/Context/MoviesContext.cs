using Microsoft.EntityFrameworkCore;
using System;
using WeekOpdrachtDependencyInjection.Business.Entities;

namespace WeekOpdrachtDependencyInjection.Business.Context
{
    public partial class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public string DbPath { get; private set; }

        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {

        }
    }
}