---
title: "How to: Create and Use Assemblies Using the Command Line (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 408ddce3-89e3-4e12-8353-34a49beeb72b
caps.latest.revision: 8
---
# How to: Create and Use Assemblies Using the Command Line (C#)
An assembly, or a dynamic linking library (DLL), is linked to your program at run time. To demonstrate building and using a DLL, consider the following scenario:  
  
-   `MathLibrary.DLL`: The library file that contains the methods to be called at run time. In this example, the DLL contains two methods, `Add` and `Multiply`.  
  
-   `Add`: The source file that contains the method `Add`. It returns the sum of its parameters. The class `AddClass` that contains the method `Add` is a member of the namespace `UtilityMethods`.  
  
-   `Mult`: The source code that contains the method `Multiply`. It returns the product of its parameters. The class `MultiplyClass` that contains the method `Multiply` is also a member of the namespace `UtilityMethods`.  
  
-   `TestCode`: The file that contains the `Main` method. It uses the methods in the DLL file to calculate the sum and the product of the run-time arguments.  
  
## Example  
  
```c#  
// File: Add.cs   
namespace UtilityMethods  
{  
    public class AddClass   
    {  
        public static long Add(long i, long j)   
        {   
            return (i + j);  
        }  
    }  
}  
```  
  
```c#  
// File: Mult.cs  
namespace UtilityMethods   
{  
    public class MultiplyClass  
    {  
        public static long Multiply(long x, long y)   
        {  
            return (x * y);   
        }  
    }  
}  
```  
  
```c#  
// File: TestCode.cs  
  
using UtilityMethods;  
  
class TestCode  
{  
    static void Main(string[] args)   
    {  
        System.Console.WriteLine("Calling methods from MathLibrary.DLL:");  
  
        if (args.Length != 2)  
        {  
            System.Console.WriteLine("Usage: TestCode <num1> <num2>");  
            return;  
        }  
  
        long num1 = long.Parse(args[0]);  
        long num2 = long.Parse(args[1]);  
  
        long sum = AddClass.Add(num1, num2);  
        long product = MultiplyClass.Multiply(num1, num2);  
  
        System.Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);  
        System.Console.WriteLine("{0} * {1} = {2}", num1, num2, product);  
    }  
}  
/* Output (assuming 1234 and 5678 are entered as command-line arguments):  
    Calling methods from MathLibrary.DLL:  
    1234 + 5678 = 6912  
    1234 * 5678 = 7006652          
*/  
```  
  
 This file contains the algorithm that uses the DLL methods, `Add` and `Multiply`. It starts with parsing the arguments entered from the command line, `num1` and `num2`. Then it calculates the sum by using the `Add` method on the `AddClass` class, and the product by using the `Multiply` method on the `MultiplyClass` class.  
  
 Notice that the `using` directive at the beginning of the file enables you to use the unqualified class names to reference the DLL methods at compile time, as follows:  
  
```c#  
MultiplyClass.Multiply(num1, num2);  
```  
  
 Otherwise, you have to use the fully qualified names, as follows:  
  
```c#  
UtilityMethods.MultiplyClass.Multiply(num1, num2);  
```  
  
## Execution  
 To run the program, enter the name of the EXE file, followed by two numbers, as follows:  
  
 `TestCode 1234 5678`  
  
## Compiling the Code  
 To build the file `MathLibrary.DLL`, compile the two files `Add` and `Mult` by using the following command line.  
  
```c#  
csc /target:library /out:MathLibrary.DLL Add.cs Mult.cs  
```  
  
 The [/target:library](../vs140/-target-library--csharp-compiler-options-.md) compiler option tells the compiler to output a DLL instead of an EXE file. The [/out](../vs140/-out--csharp-compiler-options-.md) compiler option followed by a file name is used to specify the DLL file name. Otherwise, the compiler uses the first file (`Add.cs`) as the name of the DLL.  
  
 To build the executable file, `TestCode.exe`, use the following command line:  
  
```c#  
csc /out:TestCode.exe /reference:MathLibrary.DLL TestCode.cs  
```  
  
 The **/out** compiler option tells the compiler to output an EXE file and specifies the name of the output file (`TestCode.exe`). This compiler option is optional. The [/reference](../vs140/-reference--csharp-compiler-options-.md) compiler option specifies the DLL file or files that this program uses. For more information, see [/reference](../vs140/-reference--csharp-compiler-options-.md).  
  
 For more information about building from the command line, see [Command-line Building With csc.exe](../vs140/command-line-building-with-csc.exe.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Assemblies and the Global Assembly Cache (C#)](../vs140/assemblies-and-the-global-assembly-cache--csharp-.md)   
 [Creating a Class to Hold DLL Functions](assetId:///e08e4c34-0223-45f7-aa55-a3d8dd979b0f)