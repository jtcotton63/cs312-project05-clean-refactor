# cs312-project05-clean-refactor

This is a refactor of the Project 5 framework code for BYU CS 312.

It contains the following key differences:
* There are now two types of objects: problems and solvers. Each problem contains a solver.
* Each solver implements the Solver interface.
* Each solver implementation has its own file. For example, if I want to work on the Branch and Bound implementation, I would open up BranchAndBoundSolver.cs.
* All the methods that pertain to drawing are now contained in the Form1.cs file (where they should be).
* A lot of methods with duplicated code have been condensed to use helper methods.

The interface is different in the following ways:
* The New Problem button was renamed to Generate (which makes more sense).
* Now contains a Reset to Defaults button

If you think you can make this framework code even better, you are more than welcome to submit a pull request.

Also, if something in the code doesn't make sense, feel free to leave a comment and someone will change it.

Thanks!