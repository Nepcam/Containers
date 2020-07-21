using System;
using System.Collections.Generic;
using System.Linq;

namespace Containers
{
    class Program
    {
        static int maxLoad = 28;
        static int[] items = { 8, 20, 5, 7, 42, 11, 21, 10, 2, 17 };
        static List<List<int>> containers = new List<List<int>>();
        static void Main(string[] args)
        {
            Array.Sort(items);
            Array.Reverse(items);
            foreach(int load in items)
            {
                if(load >= maxLoad)
                {
                    Console.WriteLine("The load is too big! (" + load + " t). ");
                }
                else
                {
                    bool didLoadFit = false;
                    foreach(List<int> container in containers)
                    {
                        if((container.Sum() + load) <= maxLoad)
                        {
                            container.Add(load);
                            didLoadFit = true;
                            break;
                        }
                    }

                    if (didLoadFit == false)
                    {
                        List<int> newContainer = new List<int>();
                        newContainer.Add(load);
                        containers.Add(newContainer);
                    }
                }
            }

            for(int i = 0; i < containers.Count; i++)
            {
                Console.WriteLine(" *** Container " + i + " *** ");
                Console.WriteLine("No. of items: " + containers[i].Count);
                Console.WriteLine("Weight of items: " + containers[i].Sum());
                foreach(int item in containers[i])
                {
                    Console.WriteLine("Item weight: " + item);
                }
            }
        }
    }
}
