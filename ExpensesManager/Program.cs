using System;
using System.Linq;

namespace ExpensesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string path = System.IO.Directory.GetCurrentDirectory()+"/"+file;
            if(System.IO.File.Exists(path)){
                string[] lines = System.IO.File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                decimal total = 0;
                string[] types = new string[lines.Length-1];
                for(int i=1; i<lines.Length; i++){
                    string[] line = lines[i].Split('|');
                    total += decimal.Parse( line[1]);
                    types[i-1] = line[2];
                    Console.WriteLine(lines[i]);
                }
                var distinctTypes = types.Distinct();
                int n=0;
                foreach(var type in distinctTypes){
                    n++;
                }
                Console.WriteLine($"Number of Category: {n}");
                Console.WriteLine($"Total:{total}");
            }
            else{
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
