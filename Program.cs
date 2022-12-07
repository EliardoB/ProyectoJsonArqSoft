using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;

namespace ArqSoft1
{
    internal class Program
    {
        public class student
        {
            public string Nombre { get; set; }
            public string Matricula { get; set; }
        }
        public class studenContainer
        {
            public List<student> students { get; set; }
        }
        static void Main(string[] args)
        {
            string jsonPath = @"C:\Users\eluis\source\repos\ArqSoft1\students.json";
            JsonTextReader reader = new JsonTextReader
            student st = new student();

            using (StreamReader)
            student JSONresult = (student)JsonConvert.DeserializeObject(jsonPath);

            Console.WriteLine(JSONresult);
        }

        

        
    }
}
