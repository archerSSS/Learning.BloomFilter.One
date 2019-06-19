using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BitArray bits = new BitArray(32);
            bits.Set(7, true);
            bool b1 = bits.Get(6);
            bool b2 = bits.Get(7);
        }
    }
}
