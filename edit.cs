using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbookd9
{
    internal class edit
    {
        class address
        {
            public address(string name, string address)
            {
            }

            public bool add(string name, string address)
            {
                address addr = new address(name, address);
                address result = find(name);

                if (result == null)
                {
                    object value = address.Add(addr);
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
    }
}
