using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.setStart(10);
            arith.setStep(2);
            Console.WriteLine("Арифметическая прогрессия:");
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Проверка,сброс");
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
            GeomProgression geom = new GeomProgression();
            geom.setStart(2);
            geom.setStep(3);
            Console.WriteLine("Геометрическая прогрессия:");
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine("Проверка,сброс");
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}

