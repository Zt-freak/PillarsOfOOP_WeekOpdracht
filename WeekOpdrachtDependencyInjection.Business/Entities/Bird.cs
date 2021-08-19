using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public abstract class Bird : IBird
    {
        public abstract string Sound();
    }
}
