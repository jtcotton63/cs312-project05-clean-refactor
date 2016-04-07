using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TSP
{
    class DefaultSolver : Solver
    {
        Problem _cityData;

        public DefaultSolver(Problem cityData)
        {
            this._cityData = cityData;
        }

        // This is the entry point for the default solver
        // which just finds a valid random tour 
        public Problem solve()
        {
            int i, swap, temp, count = 0;
            City[] cities = _cityData.Cities;
            string[] results = new string[3];
            int[] perm = new int[cities.Length];
            List<City> route = new List<City>();
            Random rnd = new Random();
            Stopwatch timer = new Stopwatch();

            timer.Start();
            do
            {
                for (i = 0; i < perm.Length; i++)                                 // create a random permutation template
                    perm[i] = i;
                for (i = 0; i < perm.Length; i++)
                {
                    swap = i;
                    while (swap == i)
                        swap = rnd.Next(0, cities.Length);
                    temp = perm[i];
                    perm[i] = perm[swap];
                    perm[swap] = temp;
                }
                route.Clear();
                for (i = 0; i < cities.Length; i++)                            // Now build the route using the random permutation 
                {
                    route.Add(cities[perm[i]]);
                }
                _cityData.BSSF = new TSPSolution(route);
                count++;
            } while (_cityData.BSSF.costOfRoute() == double.PositiveInfinity);                // until a valid route is found
            timer.Stop();

            // Set values that will be pushed to the screen
            // Please note that cityData.BSSF is already set above
            _cityData.TimeElasped = timer.Elapsed;
            _cityData.Solutions = count;

            return _cityData;
        }
    }
}
