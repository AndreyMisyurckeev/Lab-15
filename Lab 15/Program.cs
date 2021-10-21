using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение Х для расчета прогрессии: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(x);
            Console.Write("Арифметическая прогрессия: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{arithProgression.getNext()} ");
            }
            arithProgression.reset();
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(x);
            Console.Write("Геометрическая прогрессия: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{geomProgression.getNext()} ");
            }
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int Next;
        int count;
        public int getNext()
        {
            count += Next;
            return count;
        }

        public void reset()
        {
            Console.WriteLine();
        }

        public void setStart(int x)
        {
            Next = x;
        }
    }
    class GeomProgression : ISeries
    {
        int Next = 0;
        int count = 1;
        public int getNext()
        {
            return count *= Next;
        }

        public void reset()
        {
            Console.WriteLine();
        }

        public void setStart(int x)
        {
            Next = x;
        }
    }
}
