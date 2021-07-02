using System;

namespace Sport
{
    public class Sportsman{
        public void Play(){
            Console.WriteLine("Playing...");
        }
    }
    public class Footballer : Sportsman{
         public  void Play(){
            Console.WriteLine("Kicking ball...");
        }
    }
    public class VolleyballPlayer: Sportsman{
        public  void Play(){
            Console.WriteLine("Serving...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Footballer();
            var s2 = new VolleyballPlayer();
            s1.Play();
            s2.Play();
        }
    }
}
