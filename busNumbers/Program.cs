using System;

namespace busNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrBusses; 
            nrBusses = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] strBusses = input.Split(' ', nrBusses);
            Array.Sort(strBusses);
            int[] intBusses = Array.ConvertAll(strBusses, int.Parse);
            int start = 0, end = 1, iterator = 0, chain = 1;
            bool addOutput = false;
            string output = "";
            while (end != nrBusses && nrBusses != 0){
                if(intBusses[end] - intBusses[start] == chain){
                    output += strBusses[start];
                    if(chain >= 2){
                        Console.WriteLine("chain");   
                        addOutput = true;     
                    }
                    chain++;
                    end++;
                }else{
                    Console.WriteLine(addOutput);
                    if(addOutput){
                        output += "-"+strBusses[end];
                    }else{
                        output += " "+strBusses[iterator +1];
                    }
                    
                    chain = 1;
                    start = iterator+1;
                    end++;
                }
                addOutput = false;
                iterator++;
                

            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
