using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TestJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //read file into a string and deserialize JSON to a type
            MyHaandvaekere mhv = new MyHaandvaekere();
            MyHaandvaekere mhv2 = new MyHaandvaekere();

            mhv.Haandvaerkere  = JsonConvert.DeserializeObject<List<Haandvaerker>>(File.ReadAllText(@"json1.json"));
            Haandvaerker hv = new Haandvaerker();
            
            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"json2.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                mhv2.Haandvaerkere  = (List<Haandvaerker>)serializer.Deserialize(file, typeof(List<Haandvaerker>));
            }


            //Haandvaerker m = JsonConvert.DeserializeObject<Haandvaerker>(json);


        }
    }
}
