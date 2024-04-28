using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smily.functions
{
    public class extensions
    {
        public int count_smily(List<string> input)
        {
            List<string> smileys = new List<string>();
            try
            {                
                foreach (string val in input)
                {

                    if (val.Length == 2 && (val[0] == ':' || val[0] == ';') && (val[1] == ')' || val[1] == 'D'))
                    {
                        smileys.Add(val);
                    }
                    else if (val.Length > 2 && (val[0] == ':' || val[0] == ';') && (val[1] == '-' || val[1] == '~') && (val[val.Length - 1] == ')' || val[val.Length - 1] == 'D'))
                    {
                        smileys.Add(val);
                    }
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("error count_smily :" + ex.Message);
            }
            return smileys.Count;
        }
    }   
}
