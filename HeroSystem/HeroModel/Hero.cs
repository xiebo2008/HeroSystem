using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroModel
{
    //重构
   public class Hero
    {
       //构造函数
       bool _active =true;
        public bool Active
        {
            get { return _active; }
        }
       public Hero(string id, string name, int score)
       {
           _id = id;
           _name = name;
           _score = score;

       }
       string _id;
       public string ID
       { get { return _id; } }
       string _name;
       public string Name
       { get { return _name; } }
       int _score;
       public int Score
       {
           get { return _score; }
           set { _score = value; }
       }
    }
}
