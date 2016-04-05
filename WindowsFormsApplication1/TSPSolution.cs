﻿using System.Collections.Generic;

namespace TSP
{
    class TSPSolution
    {
        // we use the representation [cityB,cityA,cityC] 
        // to mean that cityB is the first city in the solution, cityA is the second, cityC is the third 
        // and the edge from cityC to cityB is the final edge in the path.  
        // You are, of course, free to use a different representation if it would be more convenient or efficient 
        // for your data structure(s) and search algorithm. 
        private List<City> _route;

        // route: a (hopefully) valid tour
        public TSPSolution(List<City> route)
        {
            _route = new List<City>(route);
        }

        public List<City> Route
        {
            get { return _route; }
            set { _route = value; }
        }

        // Compute the cost of the current route.  
        // Note: This does not check that the route is complete.
        // It assumes that the route passes from the last city back to the first city. 
        public double costOfRoute()
        {
            // go through each edge in the route and add up the cost. 
            int x;
            City here;
            double cost = 0D;

            for (x = 0; x < Route.Count - 1; x++)
            {
                here = Route[x] as City;
                cost += here.costToGetTo(Route[x + 1] as City);
            }

            // go from the last city to the first. 
            here = Route[Route.Count - 1] as City;
            cost += here.costToGetTo(Route[0] as City);
            return cost;
        }
    }
}
