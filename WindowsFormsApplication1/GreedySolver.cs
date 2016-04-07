using System;

namespace TSP
{
    /////////////////////////////////////////////////////////////////////////////////////////////
    // Project 6
    ////////////////////////////////////////////////////////////////////////////////////////////
    
    /*
     * Implement the greedy solver in the solve() method of this class.
     */
    class GreedySolver : Solver
    {
        Problem _cityData;

        public GreedySolver(Problem cityData)
        {
            this._cityData = cityData;
        }

        // finds the greedy tour starting from each city and keeps the best (valid) one
        // <returns>results array for GUI that contains three ints: cost of solution, time spent to find solution,
        // number of solutions found during search (not counting initial BSSF estimate)</returns>
        // For an example of what to return, see DefaultSolver.solve() method.
        public Problem solve()
        {
            throw new NotImplementedException();

            // Before returning an instance of type Problem,
            // set the following values so that text boxes 
            // on the user interface can be filled.
            // For more info, see the BranchAndBoundSolver.solve() method
            //
            // cityData.BSSF = currentBSSF;
            // cityData.TimeElasped = yourTimer.Elapsed;
            // cityData.Solutions = numSolutionsThatYouHaveCalculated;
            
            return _cityData;
        }
    }
}
