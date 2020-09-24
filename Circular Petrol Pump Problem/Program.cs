using System;

namespace Circular_Petrol_Pump_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var gas = new int[] { 1, 2, 3, 4, 5 };
            var cost = new int[] { 3, 4, 5, 1, 2 };
            Console.WriteLine(CanCompleteCircuit(gas, cost));
        }

        static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int sum = 0, position = 0, total = 0;

            for (int i = 0; i < gas.Length; ++i)
            {
                sum = sum + gas[i] - cost[i];
                if (sum < 0)
                {
                    total = total + sum;
                    sum = 0;
                    position = i + 1;
                }
            }

            total = total + sum;
            return total < 0 ? -1 : position;
        }
    }
}
