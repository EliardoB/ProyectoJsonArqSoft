using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;
using System.IO;

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
            string jsonPath = @"C:\Users\eluis\Source\Repos\ProyectoJsonArqSoft\students.json";
            string jsontext = File.ReadAllText(jsonPath);
            student st = new student();

            dynamic JSONresult = JsonConvert.DeserializeObject(jsontext);

            var arr = JSONresult["fields"].Children();

            Console.WriteLine(JSONresult);
        }

        

        
    }
}
