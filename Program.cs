using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace TestAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = new[] { (object)1, "3", 5 };
            var c = new { Name = "Lara", Agr = 33, IsValid = true };
            var arr = new[] { c };
            var result = arr.ToList();
            
            string jsonString = new JavaScriptSerializer().Serialize(c);
            string test="test";
            int cnt = test.GetSymbolCount('t');
            
            Console.WriteLine("c.Name={0}", c.Name);

            result.Clear();

            Console.WriteLine(jsonString);

            Console.ReadLine();
        }
    }
}
