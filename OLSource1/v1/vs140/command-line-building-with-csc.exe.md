---
title: "Command-line Building With csc.exe"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "CSharp"
helpviewer_keywords: 
  - "builds [C#]"
  - "command line [C#]"
ms.assetid: 66e70056-dd20-453c-a9b3-507e0478b015
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Command-line Building With csc.exe
You can invoke the C# compiler by typing the name of its executable file (csc.exe) at a command prompt.  
  
 If you use the **Visual Studio Command Prompt** window, all the necessary environment variables are set for you. In Windows 7, you can access that window from the **Start** menu by opening the Microsoft Visual Studio *Version*\Visual Studio Tools folder. In Windows 8, the Visual Studio Command Prompt is called the **Developer Command Prompt for VS2012**, and you can find it by searching from the Start screen.  
  
 If you use a standard Command Prompt window, you must adjust your path before you can invoke csc.exe from any subdirectory on your computer. You also must run vsvars32.bat to set the appropriate environment variables to support command-line builds. For more information about vsvars32.bat, including instructions for how to find and run it, see [How to: Set Environment Variables for the Visual Studio Command Line](../vs140/how-to--set-environment-variables-for-the-visual-studio-command-line.md).  
  
 If you're working on a computer that has only the [!INCLUDE[winsdklong](../vs140/includes/winsdklong_md.md)], you can use the C# compiler at the **SDK Command Prompt**, which you open from the **Microsoft .NET Framework SDK** menu option.  
  
 You can also use MSBuild to build C# programs programmatically. For more information, see [MSBuild](../vs140/msbuild.md).  
  
 The csc.exe executable file usually is located in the Microsoft.NET\Framework\\*Version* folder under the Windows directory. Its location might vary depending on the exact configuration of a particular computer. If more than one version of the .NET Framework is installed on your computer, you'll find multiple versions of this file. For more information about such installations, see [Determining Which Version of the .NET Framework Is Installed](assetId:///1a87cc6a-1c4b-4c38-b878-faa9b3beae3c).  
  
> [!TIP]
>  When you build a project by using the Visual Studio IDE, you can display the **csc** command and its associated compiler options in the **Output** window. To display this information, follow the instructions in [How to: View, Save, and Configure Build Log Files](../vs140/how-to--view--save--and-configure-build-log-files.md) to change the verbosity level of the log data to **Normal** or **Detailed**. After you rebuild your project, search the **Output** window for **csc** to find the invocation of the C# compiler.  
  
 **In this topic**  
  
-   [Rules for Command-Line Syntax](#vcconcommand-linebuildinganchor1)  
  
-   [Sample Command Lines](#vcconcommand-linebuildinganchor2)  
  
-   [Differences Between C# Compiler and C++ Compiler Output](#vcconcommand-linebuildinganchor3)  
  
##  \<a name="vcconcommand-linebuildinganchor1">\</a> Rules for Command-Line Syntax for the C# Compiler  
 The C# compiler uses the following rules when it interprets arguments given on the operating system command line:  
  
-   Arguments are delimited by white space, which is either a space or a tab.  
  
-   The caret character (^) is not recognized as an escape character or delimiter. The character is handled by the command-line parser in the operating system before it is passed to the argv array in the program.  
  
-   A string enclosed in double quotation marks ("string") is interpreted as a single argument, regardless of white space that is contained within. A quoted string can be embedded in an argument.  
  
-   A double quotation mark preceded by a backslash (\\") is interpreted as a literal double quotation mark character (").  
  
-   Backslashes are interpreted literally, unless they immediately precede a double quotation mark.  
  
-   If an even number of backslashes is followed by a double quotation mark, one backslash is put in the argv array for every pair of backslashes, and the double quotation mark is interpreted as a string delimiter.  
  
-   If an odd number of backslashes is followed by a double quotation mark, one backslash is put in the argv array for every pair of backslashes, and the double quotation mark is "escaped" by the remaining backslash. This causes a literal double quotation mark (") to be added in argv.  
  
##  \<a name="vcconcommand-linebuildinganchor2">\</a> Sample Command Lines for the C# Compiler  
  
-   Compiles File.cs producing File.exe:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   Compiles File.cs producing File.dll:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Compiles File.cs and creates My.exe:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Compiles all the C# files in the current directory, with optimizations on and defines the DEBUG symbol. The output is File2.exe:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   Compiles all the C# files in the current directory producing a debug version of File2.dll. No logo and no warnings are displayed:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   Compiles all the C# files in the current directory to Something.xyz (a DLL):  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="vcconcommand-linebuildinganchor3">\</a> Differences Between C# Compiler and C++ Compiler Output  
 There are no object (.obj) files created as a result of invoking the C# compiler; output files are created directly. As a result of this, the C# compiler does not need a linker.  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [C# Compiler Options Listed Alphabetically](../vs140/csharp-compiler-options-listed-alphabetically.md)   
 [C# Compiler Options Listed by Category](../vs140/csharp-compiler-options-listed-by-category.md)   
 [Main() and Command-Line Arguments (C# Programming Guide)](../vs140/main---and-command-line-arguments--csharp-programming-guide-.md)   
 [Command-Line Arguments (C# Programming Guide)](../vs140/command-line-arguments--csharp-programming-guide-.md)   
 [How to: Display Command Line Arguments (C# Programming Guide)](../vs140/how-to--display-command-line-arguments--csharp-programming-guide-.md)   
 [How to: Access Command-Line Arguments Using foreach (C# Programming Guide)](../vs140/how-to--access-command-line-arguments-using-foreach--csharp-programming-guide-.md)   
 [Main() Return Values (C# Programming Guide)](../vs140/main---return-values--csharp-programming-guide-.md)