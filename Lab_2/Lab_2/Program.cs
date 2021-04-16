using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var designer = new DressDesigner();
            director.Designer = designer;
            director.MakeEveningDress();
            Console.WriteLine(designer.GetDress().ListParts());
            director.MakeCocktailDress();
            Console.WriteLine(designer.GetDress().ListParts());
            Console.ReadKey();
        }
    }
}
