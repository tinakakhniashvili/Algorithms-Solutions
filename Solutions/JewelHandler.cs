using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinasAlgorithms
{
    internal class JewelHandler
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            Hashtable jewelTable = new Hashtable();

            foreach (char jewel in jewels)
            {
                if (!jewelTable.ContainsKey(jewel))
                {
                    jewelTable.Add(jewel, 0);
                }
            }

            int count = 0;

            foreach (char stone in stones)
            {
                if (jewelTable.ContainsKey(stone))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
