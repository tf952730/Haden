using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random(); //实例化一个随机数           
            string[] op = new string[] { "＋", "－", "*", "÷" };//定义一个符号数组a
            for (int i = 0; i <20; i++)
            {
                double number1 = number.Next(1, 10);//随机一个10以内的数。
                double number2 = number.Next(1, 10);//随机一个10以内的数。
                int opnext = number.Next(0,4);//随机抽取一个 "＋", "－", "*", "÷" 符号题目呀
                double s = 0;
                switch (opnext)  
                {
                    case 0:   
                        s = number1 + number2;
                        break;
                    case 1:
                        s = number1 - number2;
                        break;
                    case 2:
                        s = number1 * number2;
                        break;
                    case 3:
                        s = number1 / number2;
                        break;
                }
                Console.WriteLine(number1 + op[opnext] + number2 + "=" + s);//输出公式
            }
            Console.ReadKey();
        }
    }
}