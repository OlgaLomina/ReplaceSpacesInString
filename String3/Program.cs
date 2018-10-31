using System;
using System.Text;
//3. Write a method to replace all spaces in a string with ‘%20’.
namespace String3
{
    class Program
    {
        static string ReplaceSpaces(string str)
        {
            StringBuilder sbuild = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    sbuild.Append("%20");
                else
                    sbuild.Append(str[i]);
            }
            
            return sbuild.ToString();
        }

        static void Main(string[] args)
        {
            string str = "dog abc";
            str = ReplaceSpaces(str);
            Console.WriteLine(str);
        }
    }
}
