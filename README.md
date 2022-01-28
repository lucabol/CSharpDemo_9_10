# Demo of C# features from 9.0 to 10 
This is the starting project, you then perform the steps below, while talking about three big themes:

* Removing craft.
* Functional/Data Oriented Programming.
* Performance.

Steps:
1. Run the program to show what it does.
2. Add the function `print`, calld `.` in Forth, popping and printing the pop of the stack.
3. Move project file to .net 6, recompile.
4. Fix the Nullable error, it is the default.
5. Change to Global Usings and Implicit Usings.
6. File scoped namespace.
7. [Open up `ILSpy` and keep it open beside Visual Studio]
8. Record class for Vm, record struct for Wod (ILSpy).
8. Top Level statements (ILSpy).
9. Target new Expression for `new Vm(...)`.
10. Lambda Expr improvements (var, object, Delegate, Attributes).
11. Discard Lambda for `bye`.
12. Static lambdas (no error), Static local function for `PrintStack` (fix error).
13. Interpolated String Handler in `PrintStack` (ILSPy).
14. Native Integer types.
