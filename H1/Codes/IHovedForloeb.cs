using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Codes
{
    public interface IHovedForloeb
    {
        object[,] skole { get; }
        List<string> Search(string input, SearchCriteria criteria);

    }
}
