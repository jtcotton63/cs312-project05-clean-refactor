# cs312-project05-clean-refactor

This is a refactor of the Project 5 framework code for BYU CS 312.

It contains the following key differences:
* There are now two types of objects: problems and solvers. Each problem contains a solver.
* Each solver implements the Solver interface.
* Each solver implementation has its own file. 
** The Default implementation is found in DefaultSolver.cs.
** The Branch and Bound implementation is found in BranchAndBoundSolver.cs.
** The Greedy implementation is found in GreedySolver.cs.
** Your own implementation, which you will have to write for the group project, is found in FancySolver.cs.
* All the methods that pertain to drawing are now contained in the Form1.cs file (where they should be).
* A lot of methods with duplicated code have been condensed to use helper methods.

The interface is different in the following ways:
* The New Problem button was renamed to Generate (which makes more sense).
* Now contains a Reset to Defaults button

If you think you can make this framework code even better, you are more than welcome to submit a pull request.

Also, if something in the code doesn't make sense, feel free to leave a comment and someone will change it.

Thanks!