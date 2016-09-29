---
title: "Hello World -- Your First Program (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
f1_keywords: 
  - "cs.program"
  - "vs.csharp.startpage.firstapplication"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "examples [C#], Hello World"
  - "Hello World example [C#]"
ms.assetid: 6493182a-b0b6-4539-a719-518a168cb730
caps.latest.revision: 43
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Hello World -- Your First Program (C# Programming Guide)
The following procedure creates a C# version of the traditional "Hello World!" program. The program displays the string `Hello World!`  
  
 For more examples of introductory concepts, see [Getting Started Tutorials](../VS_csharp/getting-started-with-visual-csharp-and-visual-basic.md).  
  
 [!INCLUDE[note_settings_general](../VS_csharp/includes/note_settings_general_md.md)]  
  
### To create and run a console application  
  
1.  Start Visual Studio.  
  
2.  On the menu bar, choose **File**, **New**, **Project**.  
  
     The **New Project** dialog box opens.  
  
3.  Expand **Installed**, expand **Templates**, expand **Visual C#**, and then choose **Console Application**.  
  
4.  In the **Name** box, specify a name for your project, and then choose the **OK** button.  
  
     The new project appears in **Solution Explorer**.  
  
5.  If Program.cs isn't open in the **Code Editor**, open the shortcut menu for **Program.cs** in **Solution Explorer**, and then choose **View Code**.  
  
6.  Replace the contents of Program.cs with the following code.  
  
     [!code[csProgGuide#21](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_1.cs)]  
  
7.  Choose the F5 key to run the project. A Command Prompt window appears that contains the line `Hello World!`  
  
 Next, the important parts of this program are examined.  
  
## Comments  
 The first line contains a comment. The characters `//` convert the rest of the line to a comment.  
  
 [!code[csProgGuide#32](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_2.cs)]  
  
 You can also comment out a block of text by enclosing it between the `/*` and `*/` characters. This is shown in the following example.  
  
 [!code[csProgGuide#33](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_3.cs)]  
  
## Main Method  
 A C# console application must contain a `Main` method, in which control starts and ends. The `Main` method is where you create objects and execute other methods.  
  
 The `Main` method is a [static (C# Reference)](../VS_csharp/static--csharp-reference-.md) method that resides inside a class or a struct. In the previous "Hello World!" example, it resides in a class named `Hello`. You can declare the `Main` method in one of the following ways:  
  
-   It can return `void`.  
  
     [!code[csProgGuideMain#12](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_4.cs)]  
  
-   It can also return an integer.  
  
     [!code[csProgGuideMain#13](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_5.cs)]  
  
-   With either of the return types, it can take arguments.  
  
     [!code[csProgGuideMain#19](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_6.cs)]  
  
     -or-  
  
     [!code[csProgGuideMain#18](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_7.cs)]  
  
 The parameter of the `Main` method, `args`, is a `string` array that contains the command-line arguments used to invoke the program. Unlike in C++, the array does not include the name of the executable (exe) file.  
  
 For more information about how to use command-line arguments, see the examples in [Main() and Command Line Arguments (C# Programming Guide)](../VS_csharp/main---and-command-line-arguments--csharp-programming-guide-.md) and [How to: Create and Use C# DLLs (C# Programming Guide)](../VS_csharp/how-to--create-and-use-assemblies-using-the-command-line--csharp-and-visual-basic-.md).  
  
 The call to <xref:System.Console.ReadKey*> at the end of the `Main` method prevents the console window from closing before you have a chance to read the output when you run your program in debug mode, by pressing F5.  
  
## Input and Output  
 C# programs generally use the input/output services provided by the run-time library of the .NET Framework. The statement `System.Console.WriteLine("Hello World!");` uses the <xref:System.Console.WriteLine*> method. This is one of the output methods of the <xref:System.Console*> class in the run-time library. It displays its string parameter on the standard output stream followed by a new line. Other <xref:System.Console*> methods are available for different input and output operations. If you include the `using System;` directive at the beginning of the program, you can directly use the <xref:System*> classes and methods without fully qualifying them. For example, you can call `Console.WriteLine` instead of `System.Console.WriteLine`:  
  
 [!code[csProgGuide#1](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_8.cs)]  
  
 [!code[csProgGuide#23](../VS_csharp/codesnippet/CSharp/hello-world----your-first-program--csharp-programming-guide-_9.cs)]  
  
 For more information about input/output methods, see <xref:System.IO*>.  
  
## Command-Line Compilation and Execution  
 You can compile the "Hello World!" program by using the command line instead of the Visual Studio Integrated Development Environment (IDE).  
  
#### To compile and run from a command prompt  
  
1.  Paste the code from the preceding procedure into any text editor, and then save the file as a text file. Name the file `Hello.cs`. C# source code files use the extension `.cs`.  
  
2.  Perform one of the following steps to open a command-prompt window:  
  
    -   In Windows 8, on the **Start** screen, search for `Developer Command Prompt`, and then tap or choose **Developer Command Prompt for VS2012**.  
  
         A Developer Command Prompt window appears.  
  
    -   In Windows 7, open the **Start** menu, expand the folder for the current version of Visual Studio, open the shortcut menu for **Visual Studio Tools**, and then choose **Developer Command Prompt for VS2012**.  
  
         A Developer Command Prompt window appears.  
  
    -   Enable command-line builds from a standard Command Prompt window.  
  
         See [How to: Set Environment Variables](../VS_csharp/how-to--set-environment-variables-for-the-visual-studio-command-line.md).  
  
3.  In the command-prompt window, navigate to the folder that contains your `Hello.cs` file.  
  
4.  Enter the following command to compile `Hello.cs`.  
  
     `csc Hello.cs`  
  
     If your program has no compilation errors, an executable file that is named `Hello.exe` is created.  
  
5.  In the command-prompt window, enter the following command to run the program:  
  
     `Hello`  
  
 For more information about the C# compiler and its options, see [C# Compiler Options](../VS_csharp/csharp-compiler-options.md).  
  
## Featured Book Chapter  
 [Writing a C# Program](http://go.microsoft.com/fwlink/?LinkId=221227) in [Beginning Visual C# 2010](http://go.microsoft.com/fwlink/?LinkId=221214)  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Inside a C# Program](../VS_csharp/inside-a-csharp-program.md)   
 [Strings (C# Programming Guide)](../VS_csharp/strings--csharp-programming-guide-.md)   
 [<paveover\>C# Sample Applications](assetId:///9a9d7aaa-51d3-4224-b564-95409b0f3e15)   
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [Main() and Command-Line Arguments (C# Programming Guide)](../VS_csharp/main---and-command-line-arguments--csharp-programming-guide-.md)   
 [Getting Started Tutorials](../VS_csharp/getting-started-with-visual-csharp-and-visual-basic.md)