using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System;

namespace TSP
{
    /////////////////////////////////////////////////////////////////////////////////////////////
    // Project 5
    ////////////////////////////////////////////////////////////////////////////////////////////

    /*
     * Implement your branch and bound solver in the solve() method of this class.
     */
    class BranchAndBoundSolver : Solver
    {
        Problem _cityData;

        public BranchAndBoundSolver(Problem cityData)
        {
            this._cityData = cityData;
        }

        // finds the best tour possible using the branch and bound method of attack
        public Problem solve()
        {
            throw new NotImplementedException();

            Stopwatch timer = new Stopwatch();
            timer.Start();



            // Implement your branch and bound code here //



            timer.Stop();



            /* Before returning an instance of type Problem, do the following: */

            // Set the route so it can be drawn on the screen.
            // This is done through the Problem.BSSF variable, 
            // which contains a List<City> that is the route.
            //
            // For example:
            // List<City> routeOfBestSolutionFoundSoFar;
            // cityData.BSSF = new TSPSolution(routeOfBestSolutionFoundSoFar);
            _cityData.BSSF = null; // CHANGE THIS LINE



            // Set the TimeElasped variable so the box can be filled
            // on the GUI:
            _cityData.TimeElasped = timer.Elapsed;



            // As part of Project 5, you need to keep track of how
            // many solutions your algorithm finds. The best way is to use a counter.
            //
            // When you've finished solving the problem,
            // set the number of solutions to the value of the counter
            // so that it is shown on the GUI.
            //
            // For example:
            // int yourNumberOfSolutionsCounter;
            // cityData.Solutions = yourNumberOfSolutionsCounter;
            _cityData.Solutions = -1; // CHANGE THIS LINE



            // Show the three numbers necessary for the project 5 report
            // 
            // For example:
            // showVariablesMessagePopup(yourNumberOfChildStatesCounter,
            //                           yourNumberOfStatesPrunedCounter,                          
            //                           yourLargestQueueSizeCounter);
            showVariablesMessagePopup(-1, -1, -1); // CHANGE THIS LINE



            return _cityData;
        }

        // The Project 5 report requires you to find the following three numbers:
        // numChildStatesGenerated: The number of child states that your alrogithm generated
        // numStatesPruned: The number of states that were pruned by your algorithm
        // largestQueueSize: The largest number of states that were stored in your queue
        //                   at any one given time
        //
        // You should have counters to keep track of all of these numbers.
        //
        // When you are done, you need a way to display this numbers so that you can use them in your report.
        // This function is provided for you so that you can easily print these numbers to the screen.
        private void showVariablesMessagePopup(int numChildStatesGenerated,
                                               int numStatesPruned,
                                               int largestQueueSize)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Number of Child States Generated:");
            sb.Append(" ");
            sb.Append(numChildStatesGenerated);
            sb.Append("\n");
            sb.Append("Number of States Pruned:");
            sb.Append(" ");
            sb.Append(numStatesPruned);
            sb.Append("\n");
            sb.Append("Largest Queue Size:");
            sb.Append(" ");
            sb.Append(largestQueueSize);
            MessageBox.Show(sb.ToString());
        }
    }
}
