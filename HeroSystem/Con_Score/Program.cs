using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroModel;
using IHero;
using Cloud;
namespace Con_Score
{
    class Program
    {
        static int g_count =0;
        static IHeroOperate g_heroOp = new HeroCloud();
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到英雄无敌的游戏");
            Init();
            ShowHeros();
            Login();

        }

        private static void Login()
        {
            Console.WriteLine("-------------------------------------");
            while (true)
            {
                Console.WriteLine("请输入用户名 ：");
                string username = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                string password = Console.ReadLine();
                if (username == "admin" && password == "123456")
                {
                    g_count++;
                    Console.WriteLine("你第{0}次登陆",g_count);
                    gotoMenu();
                }
                else
                {
                    Console.WriteLine("用户名密码错误");
                }
            }

        }

        private static void gotoMenu()
        {
            bool exit = false;
            while (!exit)
            { 
            Console.WriteLine("进入菜单 1 查询 2 修改积分 3冻结/激活账户   0退出");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": Query();
                    break;
                case "2": Modify();
                    break;
                case "0": exit = true ;
                    break;
                default:break;
            }
            }
        }

        private static void Modify()
        {
            Hero h = Query();
            if (h != null)             
            {
                Console.WriteLine("请输入你要修改的积分");
                int　newScore;
                if (int.TryParse(Console.ReadLine(), out newScore))
                {
                    h.Score = newScore;
                }
                else 
                {
                    Console.WriteLine("输入错误");
                }
                ShowHeros();

            }
             
        }

        private static Hero Query()
        {
            Console.WriteLine("请输入编号:");
            string id = Console.ReadLine();
            //for 循环查找

            Hero h= g_heroOp.GetAllHeros().First(x => x.ID == id);

            if (h == null)
            {
                Console.WriteLine("没找到");
            }
            else
            {
                Console.WriteLine("id:{0},name:{1},score:{2} ", h.ID, h.Name, h.Score);

            }
            return h;
       
        }

        private static void ShowHeros()
        {
           
            foreach (Hero h in g_heroOp.GetAllHeros())
            {
                Console.WriteLine("id:{0},name:{1},score:{2}, 是否激活{3} ", h.ID, h.Name, h.Score,h.Active);

            }
        }
        static void Init()
        {
            Hero h1 = new Hero("2002", "张三丰", 300);
            Hero h2 = new Hero("2003", "张无忌", 200);
            g_heroOp.Add(h1);
            g_heroOp.Add(h2);


        }

    }
}
