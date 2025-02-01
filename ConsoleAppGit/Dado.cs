using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit
{
    internal class Dado
    {
        public int Lancia()
        { 
            Random random = new Random();
            return random.Next(1,7);
        }
    }
}
