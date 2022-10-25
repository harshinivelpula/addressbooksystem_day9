using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbookd9
{
    internal class delete
    {
        public bool remove(string name, object addresses)
        {
            address addr = find(name);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        private address find(string name)
        {
            throw new NotImplementedException();
        }
    }

    internal class address
    {
    }
}
