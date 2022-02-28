# Demo of C# features from 9.0 to 10 
This is the starting project, you then perform the steps below, while talking about three big themes:

* Removing craft.
* Functional/Data Oriented Programming.
* Performance.

Steps:
1. Show the usual StackOverflow survey (both useful and loved).
2. Run the program to show what it does.
3. Add the function `print`, calld `.` in Forth, popping and printing the pop of the stack.
4. Move project file to 'net6.0', recompile.
5. Fix the Nullable error, it is the default.
6. Change to Global Usings and <implicitUsings>.
7. File scoped namespace.
8. [Open up `ILSpy` and keep it open beside Visual Studio]
9. Record class for Vm, record struct for Wod (ILSpy).
10. Top Level statements (ILSpy).
11. Target new Expression for `new Vm(...)`.
12. Lambda Expr improvements (var, object, Delegate, Attributes).
13. Discard Lambda for `bye`.
14. Static lambdas (no error), Static local function for `PrintStack` (fix error).
15. Interpolated String Handler in `PrintStack` (ILSPy).
16. Native Integer types.
