using manipulate.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulate.functions
{
    public class extensions
    {
        public string verifyInput(string? input)
        {
            string result = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    result = "0";
                }
                else
                {
                    result = input;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error verifyInput :" + ex.Message);
            }
            return result;
        }
        public void Permutations(string input,string answer)
        {
            string value = string.Empty ;
            List<string> list = new List<string>();
            try
            {
                
                if (input.Length == 0)
                {
                    Console.Write(answer + "  ");
                }

                for (int i = 0; i < input.Length; i++)
                {
                    char data = input[i];
                    string left_substr = input.Substring(0, i);
                    string right_substr = input.Substring(i + 1);
                    string result = left_substr + right_substr;
                    Permutations(result, answer + data);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("error Permutations :" + ex.Message);

            }
        }        
    }
}
