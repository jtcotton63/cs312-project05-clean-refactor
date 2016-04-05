using System;

namespace TSP
{
    /////////////////////////////////////////////////////////////////////////////////////////////
    // Project 6
    ////////////////////////////////////////////////////////////////////////////////////////////

    /*
     * Implement your own 'fancy' TSP solver in the solve() method of this class.
     */
    class FancySolver : Solver
    {
        Problem cityData;

        public FancySolver(Problem cityData)
        {
            this.cityData = cityData;
        }

        // finds the best tour possible using your own fancy TSP solving method
        // <returns>results array for GUI that contains three ints: cost of solution, time spent to find solution,
        // number of solutions found during search (not counting initial BSSF estimate)</returns>
        // For an example of what to return, see DefaultSolver.solve() method.
        public Problem solve()
        {
            throw new NotImplementedException();

            // Before returning an instance of type Problem,
            // set the following values so that text boxes 
            // on the user interface can be filled:
            //
            // cityData.BSSF = currentBSSF;
            // cityData.TimeElasped = yourTimer.
            // cityData.Solutions = numSolutionsThatYouHaveCalculated;
            //
            // return cityData;
        }
    }
}
