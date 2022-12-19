using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exes_20210140129_klmpok4
{
    class Program
    {
        int ND, NB, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            ND = -1;
            NB = -1;
        }

        public void input(int element)
        {
          if((ND == 0 && NB == max -1) || (ND == NB +1))
            {
                Console.WriteLine("\nQueue overflow\n");
                    return;
            }
          if(ND == -1)
            {
                ND = 0;
                NB = 0;
            }
          else
            {
                if(NB ==max -1)
                    NB = 0;
                else
                    NB = NB +1;
            }
          queue_array[NB] = element;
        }
    }
}