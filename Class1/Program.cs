
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Human
            

            //Human human1 = new Human("Ramin", "Aliyev", 24, "Baku");
            //Human human2 = new Human("Huseyin", "Huseyinov", 27, "Gence");
            //Human human3 = new Human("Elvin", "Aliyev", 22, "Baku");
            //Human human4 = new Human("Cavid", "Aliyev", 30, "istanbul");

            //human1.IsStudent();

            Human human = new Human();
            //human.CheckCity(human1.City, human2.City);

            //Human human5=new Human("Mehemmed","Memmedli",38,"oguz");
            //Human human6=new Human("Alim", "Qasimov", 34, "siyezen");
            //Human human7=new Human("Mehman", "Qasimli", 23, "quba");
            //Human human8=new Human("Ali", "Aliyev", 21, "baki");
            //Human human9=new Human("Huseyin", "Cavadov", 3, "sumqayit");


            //Human[] arr = { human8, human6,human7,human9,human5 };

            Human[] insanlar = new Human[]
            {
             new Human("Mehemmed","Memmedli",38,"mingecevir"),
             new Human("Alim", "Qasimov", 34, "yevlax"),
             new Human("Mehman", "Qasimli", 23, "baki"),
             new Human("Ali", "Aliyev", 21, "yevlax"),
             new Human("Huseyin", "Cavadov", 3, "mingecevir"),
            };





            foreach (var insan in insanlar)
            {
                var (seher, count, telebeadlari) = insan.GetCount(insanlar);
                if (count > 1)
                {
                    Console.WriteLine($"{seher} seherinde {count} telebe var: {telebeadlari}");
                }
            }
            #endregion


        }
    }
}
