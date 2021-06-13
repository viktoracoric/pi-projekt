using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reRack.Design
{
    public class DataException : ApplicationException
    {
        public string Poruka { get; set; }
        public DataException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
