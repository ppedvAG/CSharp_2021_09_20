using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_02_Fuhrpark
{
    public interface IWindAntrieb
    {
         int Mastanzahl { get; set; }
         int InsegesamteSegelFläche { get; set; }
    }
}
