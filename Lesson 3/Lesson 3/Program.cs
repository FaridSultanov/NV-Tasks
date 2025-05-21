using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            goto There;
            short var1, var2;
            Console.Write("Enter first number: ");
            var1 = short.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            var2 = short.Parse(Console.ReadLine());
            Console.WriteLine(Odd_or_even(var1,var2));

            

            string var3, var4;
            Console.Write("Enter first string:");
            var3 = Console.ReadLine();
            Console.Write("Enter second string:");
            var4 = Console.ReadLine();
            Console.WriteLine(Contain(var3,var4));

        
            int var5, var6;
            Console.Write("Enter first number:");
            var5 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number :");
            var6 = int.Parse(Console.ReadLine());
            Console.WriteLine(Devide(var5,var6));
        
            Console.WriteLine(Tempareture_conservation());
        

            Console.WriteLine(Remove_Character());


            There:

            Console.WriteLine(Swap_First_Last());
        }
        #region Task1
        public static bool Odd_or_even(short var1,short var2)
        {
           
            if((var1%2==0 && var2%2==0) || (var1%2==1 && var2%2==1))
            {
                return true;
            }
           
                return false;
        }
        #endregion

        #region Task2
        public static bool Contain(string var1,string var2)
        {
            return true ? var2.Contains(var2) : false;
               
           
        }

        #endregion

        #region Task3
        static float Devide(int num1,int num2)
        {
            float var1 = (float)(num1) /(float)( num2);
            return var1;
        }
        #endregion

        #region Task 4 (Celci to Farenheyt)
        static string Tempareture_conservation(/*int temp,string str*/)
        {
            byte choose;
            float temp;
            string str=" ";
            while(true)
            {
                Console.WriteLine("Choose your option!    1. C -> F      2. F->C");
                Console.Write("Choise :");
                choose = byte.Parse(Console.ReadLine());
                Console.Write("Enter the tempature :");
                temp = int.Parse(Console.ReadLine());
                if(choose==1)
                {
                    temp = (temp * 9) / 5 + 32;
                    str = temp.ToString() + " F";
                }
                else if(choose==2)
                {
                    temp = (temp - 32) * 5 / 9;
                    str = temp.ToString() + " C";
                }

                break;

            }
            return str;
        }
        #endregion

        #region Task 5 Remove Character
         static string Remove_Character()
        {
            string word; char ch;
            Console.Write("Enter word: ");
            word = Console.ReadLine();
            Console.Write("Enter character: ");
            ch = char.Parse(Console.ReadLine());
            int len = word.Length;
            string sum = " ";
            for(int i=0;i<len;i++)
            {
                if (word[i]!=ch)
                {
                    sum += word[i];
                }
            }

            return sum ;
        }
        #endregion

        #region Task 6 Swap First and Last Characters
        static string Swap_First_Last()
        {
            Console.Write("Enter string :");
            string str = Console.ReadLine();
            string str_first = str[0].ToString();
            string new_string = str.Substring(1, str.Length - 2);
            new_string=str[str.Length - 1]+new_string ;
            new_string += str_first;
            return new_string;
        }
        #endregion


    }
}
