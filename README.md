# GradeChecker
My First simple if-else C# console application that takes user's marks as inputs and outputs whether they passed or failed.

## Logic
- if the entered marks are 50 or higher, it prints"Pass"
- if the entered marks are below 50, it prints "Fail"

## Code Example
```Csharp
Console.Write("Enter Your Marks:");
int Marks = int.Parse(Console.ReadLine());

if (Marks >= 50)
    Console.WriteLine("Pass");
else
    Console.WriteLine("Fail");
Console.ReadLine();
```
