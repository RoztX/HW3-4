using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    public interface IFilter
    {
        public Transport[] Filter(Transport[] transports);
    }
}
