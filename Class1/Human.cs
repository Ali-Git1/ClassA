using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Human
    {
        #region Human

        public string Name;
        public string SurName;
        public int Age;
        public string City;

        public Human(string name, string surname, int age, string city)
        {
            Name = name;
            SurName = surname;
            Age = age;
            City = city;
            
        }
        public Human()
        {
            
        }



        public bool IsStudent()
        {
            return Age >= 18 && Age <= 25;
        }

        public void CheckCity(string city1,string city2)
        {
            if (city1 == city2) Console.WriteLine("Uygun");
            else Console.WriteLine("Deyil");
        }



        //public void GetCount(Human[] humans)
        //{
        //    //foreach (var item in humans)
        //    //{
        //    //    Console.WriteLine(item.City);
        //    //}
        //    int count = 0;
        //    for (int i = 0; i < humans.Length; i++)
        //    {
        //        Console.WriteLine(humans[i].City);

        //    }
        //}

        public (string, int,string) GetCount(Human[] insanlar) 
        {
            int count = 0;
            string telebeadlari = "";
            string muqayiseseher = City.ToLower(); 
            foreach (var insan in insanlar)
            {
                string muqayiseinsan = insan.City.ToLower(); 
                if (Muqayise(muqayiseinsan, muqayiseseher))
                {
                    count++;
                    if (telebeadlari != "")
                    {
                        telebeadlari += ", ";
                    }
                    telebeadlari += insan.Name + " " + insan.SurName;
                }
            }
            return (City, count,telebeadlari);
        }

        
        private bool Muqayise(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            for (int i = 0; i < str1.Length; i++)
            {
                if (char.ToLower(str1[i]) != char.ToLower(str2[i]))
                    return false;
            }

            return true;
        }
      


       

        #endregion
    }

   
}
