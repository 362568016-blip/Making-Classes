using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
    public class Die
    {
        private int _sides;
        private int _roll;
        private Random _generator;

        public Die()
        {
            _generator = new Random();
            _sides = 6;
            _roll = _generator.Next(1, _sides + 1);
        }
        //public Die(int sides)
        //{
        //    _generator = new Random();
        //    _sides = _sides;
        //    _roll = _generator.Next(1, _sides + 1);
        //}

        //properties
        public int Roll 
        { 
            get { return _roll; } 
            //set { _roll = value; }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, _sides + 1);
        }

        public void DrawRoll()
        {
            Console.WriteLine("-----");
            {
                if (_roll == 1)
                {
                    Console.WriteLine("|   |");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|   |");
                }
                else if (_roll == 2)
                {
                    Console.WriteLine("|o  |");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|  o|");
                }
                else if (_roll == 3)
                {
                    Console.WriteLine("|o  |");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|  o|");
                }
                else if (_roll == 4)
                {
                    Console.WriteLine("|o  o|");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|o  o|");
                }
                else if (_roll == 5)
                {
                    Console.WriteLine("|o  o|");
                    Console.WriteLine("|  o |");
                    Console.WriteLine("|o  o|");
                }
                else if (_roll == 6)
                {
                    Console.WriteLine("|o  o|");
                    Console.WriteLine("|o  o|");
                    Console.WriteLine("|o  o|");
                }
            }


            Console.WriteLine("-----");
        }
    }
}
