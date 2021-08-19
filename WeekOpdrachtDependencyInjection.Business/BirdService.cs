using System.Collections.Generic;
using System.Linq;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business
{
    public class BirdService : IBirdService
    {
        private readonly IEnumerable<IBird> _birds;

        public BirdService(IEnumerable<IBird> birds)
        {
            _birds = birds;
        }

        public IBird GetBirdByType(string birdName)
        {
            var bird = _birds.Single(x => x.GetType().Name.ToLower() == birdName.ToLower());
            return bird;
        }
    }
}
