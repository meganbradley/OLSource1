---
title: "F# Interactive (fsi.exe) Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "VS.FSharpInteractive"
  - "VS.ToolsOptionsPages.F#_Tools.F#_Interactive"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "F# interactive"
  - "fsi.exe [F#]"
ms.assetid: 9c53cd28-8731-45a9-ab7e-5436fd2284da
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# F# Interactive (fsi.exe) Reference
F# Interactive (fsi.exe) is used to run F# code interactively at the console, or to execute F# scripts. In other words, F# interactive executes a REPL (Read, Evaluate, Print Loop) for the F# language.  
  
## Interactive Programming with F#  
 F# Interactive can be used to write code at the console or in a window in Visual Studio.  
  
 To run F# Interactive from the console, run fsi.exe.  You will find fsi.exe in “c:\Program Files (x86)\Microsoft SDKs\F#\\<version\>\Framework\\<version\>\”. For information about command line options available, see [F# Interactive Options](../vs140/fsharp-interactive-options.md).  
  
 To run F# Interactive through Visual Studio, you can click the appropriate toolbar button labeled **F# Interactive**, or use the keys <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Doing this will open the interactive window, a tool window running an F# Interactive session. You can also select some code that you want to run in the interactive window and hit the key combination <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. F# Interactive starts in a tool window labeled **F# Interactive**. When you use this key combination, make sure that the editor window has the focus.  
  
 Whether you are using the console or Visual Studio, a command prompt appears and the interpreter awaits your input. You can enter code just as you would in a code file. To compile and execute the code, enter two semicolons (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) to terminate a line or several lines of input.  
  
 F# Interactive attempts to compile the code and, if successful, it executes the code and prints the signature of the types and values that it compiled. If errors occur, the interpreter prints the error messages.  
  
 Code entered in the same session has access to any constructs entered previously, so you can build up programs. An extensive buffer in the tool window allows you to copy the code into a file if needed.  
  
 When run in Visual Studio, F# Interactive runs independently of your project, so, for example, you cannot use constructs defined in your project in F# Interactive unless you copy the code for the function into the interactive window.  
  
 If you have a project open that references some libraries, you can reference these in F# Interactive through **Solution Explorer**. To reference a library in F# Interactive, expand the **References** node, open the shortcut menu for the library, and choose **Send to F# Interactive**.  
  
 You can control the F# Interactive command line arguments (options) by adjusting the settings. On the **Tools** menu, select **Options...**, and then expand **F# Tools**. The two settings that you can change are the F# Interactive options and the **64-bit F# Interactive** setting, which is relevant only if you are running F# Interactive on a 64-bit machine. This setting determines whether you want to run the dedicated 64-bit version of fsi.exe or fsianycpu.exe, which uses the machine architecture to determine whether to run as a 32-bit or 64-bit process.  
  
## Scripting with F#  
 Scripts use the file extension <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Instead of compiling source code and then later running the compiled assembly, you can just run <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and specify the filename of the script of F# source code, and F# interactive reads the code and executes it in real time.  
  
## Differences Between the Interactive, Scripting and Compiled Environments  
 When you are compiling code in F# Interactive, whether you are running interactively or running a script, the symbol <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is defined. When you are compiling code in the compiler, the symbol <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is defined. Thus, if code needs to be different in compiled and interactive modes, you can use preprocessor directives for conditional compilation to determine which to use.  
  
 Some directives are available when you are executing scripts in F# Interactive that are not available when you are executing the compiler. The following table summarizes directives that are available when you are using F# Interactive.  
  
|Directive|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Displays information about available directives.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Specifies an assembly search path in quotation marks.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Reads a source file, compiles it, and runs it.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Terminates an F# Interactive session.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|References an assembly.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|By itself, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> toggles whether to display performance information. When it is enabled, F# Interactive measures real time, CPU time, and garbage collection information for each section of code that is interpreted and executed.|  
  
 When you specify files or paths in F# Interactive, a string literal is expected. Therefore, files and paths must be in quotation marks, and the usual escape characters apply. Also, you can use the @ character to cause F# Interactive to interpret a string that contains a path as a verbatim string. This causes F# Interactive to ignore any escape characters.  
  
 One of the differences between compiled and interactive mode is the way you access command line arguments. In compiled mode, use \<xref:System.Environment.GetCommandLineArgs*>. In scripts, use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The following code illustrates how to create a function that reads the command line arguments in a script and also demonstrates how to reference another assembly from a script. The first code file, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, is the code for the assembly being referenced. Compile this file with the command line: <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and then execute the second file as a script with the command line: <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> test  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The output is as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[F# Interactive Options](../vs140/fsharp-interactive-options.md)|Describes command line syntax and options for the F# Interactive, fsi.exe.|  
|[F# Interactive Library Reference](../vs140/fsharp-interactive-library-reference.md)|Describes library functionality available when executing code in F# interactive.|