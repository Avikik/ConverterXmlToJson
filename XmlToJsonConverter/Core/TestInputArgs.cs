using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToJsonConverter.Core
{
    public class TestInputArgs
    {
        string[] args;

        public TestInputArgs(string[] args)
        {
            this.args = args;
        }
        public  bool isCountArgsOk()
        {
            return !(isCountArgsMoreTwo() || isCountArgsZero() || isCountArgsOne());
        }

        private bool isCountArgsMoreTwo()
        {
            if (args.Length > 2)
            {
                Console.WriteLine("ERROR:Указанно больше 2 аргументов");
                return true;
            }                
            return false;
        }

        private bool isCountArgsZero()
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR:Вы не указали имя входного файла");
                return true;
            }
            return false;
        }

        private bool isCountArgsOne()
        {
            if (args.Length == 1)
            {
                Console.WriteLine("ERROR:Вы не указали имя второго аргумета. Второй параметр ввиде выходного файла");
                return true;
            }
            return false;
        }
    }
}
