using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitactionstest
{
    public class Cases
    {
        public enum CaseWorkers
        {
            Joe = 1,
            Jane = 2,
            Mark = 3,
            Tina = 4,
            Bryan = 5
        }

        public void ExplodeString(string a)
        {
            foreach (var i in a)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
