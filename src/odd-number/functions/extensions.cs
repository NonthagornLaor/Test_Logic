using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_number.functions
{
    public class extensions
    {
        public string verify(string input)
        {
            string result = string.Empty;
            try
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                foreach (char val in input)
                {
                    if (dict.ContainsKey(val))
                    {
                        dict[val] = dict[val] + 1;
                    }
                    else
                    {
                        dict.Add(val, 1);
                    }
                }
                foreach (var item in dict.Keys)
                {
                    Console.WriteLine(item + " : " + dict[item] + " count ");
                    if (dict[item] % 2 != 0)
                    {
                        result = item.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error verify :" + ex.Message);
            }
            return result;
        }
    }
}
