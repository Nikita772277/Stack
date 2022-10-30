using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staples
{
    internal class Stackk
    {
        public bool Staples()
        {
            Console.WriteLine($"Введите скобки");
            Stack<char> stack = new Stack<char>();
            string staples = Console.ReadLine();
            Console.WriteLine();
            if (staples == " " || staples == "")
            {
                Console.WriteLine($"Вы нечего не ввели");
                return false;
            }
            else
            {
                foreach (char stac in staples)
                {
                    //if (stac == '(' || stac == ')' || stac == '[' || stac == ']' || stac == '{' || stac == '}')
                    // {


                    if (stac == '(' || stac == '{' || stac == '[')
                    {
                        stack.Push(stac);
                    }
                    else if (stac == ')')
                    {
                        if (stack.Count() == 0) { return false; }
                        if (stack.Pop() != '(') { return false; }
                    }
                    else if (stac == ']')
                    {
                        if (stack.Count() == 0) { return false; }
                        if (stack.Pop() != '[') { return false; }
                    }
                    else if (stac == '}')
                    {
                        if (stack.Count() == 0) { return false; }
                        if (stack.Pop() != '{') { return false; }
                    }
                    //}
                    else
                    {

                        continue;
                    }
                }
            }

            return stack.Count() == 0;

        }
    }
}
