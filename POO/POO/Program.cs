using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Person person = new Person
            {
                Name = "Edgar",
                Edad = 26,
                Address = "Santa Catarina, Monterrey" 
            };

            string output = JsonConvert.SerializeObject(person);

            FileStream fs = new FileStream(@"C:\Users\Curso\source\repos\Desktop\Tutoria\POO\POO\Sample.txt", FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }


            // Open the stream and read it back.
            using (StreamReader sr = File.OpenText(@"C:\Users\Curso\source\repos\Desktop\Tutoria\POO\POO\Sample.txt"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    Console.ReadLine();
                }
            }
        }

    }
}
