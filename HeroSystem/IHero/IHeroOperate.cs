using HeroModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHero
{
    //接口  : 一堆未实现的方法标签 集合----标准
    public interface IHeroOperate
    {
        void Add(Hero h);
        void Froze(string id);
        void unFroze(string id);
        void Modify(string id, int score);
        Hero[] GetAllHeros();
        Hero[] GetActiveHeros();
        Hero GetHero(string id);
    }
}
