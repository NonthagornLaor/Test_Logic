using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulate.models
{
    public class manipulatemodel
    {
    }
    public class Input
    {
        public string? inputValue { get; set; }
    }
    public class OutputList
    {
        public List<OutputData>? outputValue { get; set; }
    }
    public class OutputData
    {
        public string outputData { get; set; }  
    }
}
