using HeroModel;
using IHero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud
{
    public class HeroCloud : IHeroOperate
    {
        List<Hero> heroList = new List<Hero>();
        public void Add(Hero h)
        {
            throw new NotImplementedException();
        }

        public void Froze(string id)
        {
            throw new NotImplementedException();
        }

        public Hero[] GetActiveHeros()
        {
            throw new NotImplementedException();
        }

        public Hero[] GetAllHeros()
        {
            throw new NotImplementedException();
        }

        public Hero GetHero(string id)
        {
            throw new NotImplementedException();
        }

        public void Modify(string id, int score)
        {
            throw new NotImplementedException();
        }

        public void unFroze(string id)
        {
            throw new NotImplementedException();
        }
    }
}
