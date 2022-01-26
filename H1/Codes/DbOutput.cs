using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Codes
{
    internal record DbOutput
    {
        private readonly List<string> _output = new List<string>();

        public DbOutput(List<string> input)
        {
            foreach (var item in input)
            {
                _output.Add(item);
            }
        } 

        public List<string> Output()
        {
            return _output;
        }
    }
}
