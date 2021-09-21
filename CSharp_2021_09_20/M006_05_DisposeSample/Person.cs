using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_05_DisposeSample
{
    public class Person : IDisposable
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Dispose()
        {
            Id = null;
            FirstName = null;
            LastName = null;
        }
    }
}
