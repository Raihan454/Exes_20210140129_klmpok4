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
        public void delete()
        {
            if (ND == -1)
            {
                Console.WriteLine("\nQueue underflow\n");
                return;
            }
            Console.WriteLine("\nThe Element deleted from the queue is" + queue_array[ND]
                + "\n");
            if(ND == NB)
            {
                ND = -1;
                NB = -1;
            }
            else
            {
                if (ND == max - 1)
                    ND = 0;
                else
                    ND = ND + 1;
            }
        }
        public void display()
        {
            int ND_position = ND;
            int NB_position = NB;
            if (ND == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return ;
            }
            Console.WriteLine("\nElements in the queue are .................\n");
            if (ND_position <= NB_position)
            {
                while(ND_position <= NB_position)
                {
                    Console.Write(queue_array[ND_position] + "   ");
                    ND_position++;
                }
                Console.WriteLine();
            }
            else
            {
                while (ND_position <= max - 1)
                {
                    Console.Write(queue_array[ND_position] + "   ");
                    ND_position++;
                }
                ND_position = 0;
                while (ND_position <= NB_position)
                {
                    Console.Write(queue_array[ND_position] + "   ");
                    ND_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program queue = new Program();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display value");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4):  ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("Enter a abjad:  ");
                                int abjad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                queue.input(abjad);
                            }
                            break;
                        case '2':
                            {
                                queue.delete();
                            }
                            break;
                        case '3':
                            {
                                queue.display();
                            }
                            break;
                    }
                }
            }
        }
    }
}