---
title: "Main() Return Values (C# Programming Guide)"
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
helpviewer_keywords: 
  - "Main method [C#], return values"
ms.assetid: c2f5a1d8-1676-4bea-bc7e-44a97e72d5bc
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Main() Return Values (C# Programming Guide)
The `Main` method can return `void`:  
  
 [!code[csProgGuideMain#12](../vs140/codesnippet/CSharp/main---return-values--csharp-programming-guide-_1.cs)]  
  
 It can also return an `int`:  
  
 [!code[csProgGuideMain#13](../vs140/codesnippet/CSharp/main---return-values--csharp-programming-guide-_2.cs)]  
  
 If the return value from `Main` is not used, returning `void` allows for slightly simpler code. However, returning an integer enables the program to communicate status information to other programs or scripts that invoke the executable file. The following example shows how the return value from `Main` can be accessed.  
  
## Example  
 In this example, a batch file is used to run a program and test the return value of the `Main` function. When a program is executed in Windows, any value returned from the `Main` function is stored in an environment variable called `ERRORLEVEL`. A batch file can determine the outcome of execution by inspecting the `ERRORLEVEL` variable. Traditionally, a return value of zero indicates successful execution. The following example is a simple program that returns zero from the `Main` function. The zero indicates that the program ran successfully. Save the program as MainReturnValTest.cs.  
  
 [!code[csProgGuideMain#14](../vs140/codesnippet/CSharp/main---return-values--csharp-programming-guide-_3.cs)]  
  
## Example  
 Because this example uses a batch file, it is best to compile the code from a command prompt. Follow the instructions in [How to: Build from the Command Line](../vs140/how-to--set-environment-variables-for-the-visual-studio-command-line.md) to enable command-line builds, or use the Visual Studio Command Prompt, available from the **Start** menu under **Visual Studio Tools**. From the command prompt, navigate to the folder in which you saved the program. The following command compiles MainReturnValTest.cs and produces the executable file MainReturnValTest.exe.  
  
 `csc MainReturnValTest.cs`  
  
 Next, create a batch file to run MainReturnValTest.exe and to display the result. Paste the following code into a text file and save it as `test.bat` in the folder that contains MainReturnValTest.cs and MainReturnValTest.exe. Run the batch file by typing `test` at the command prompt.  
  
 Because the code returns zero, the batch file will report success. However, if you change MainReturnValTest.cs to return a non-zero value and then re-compile the program, subsequent execution of the batch file will report failure.  
  
```  
rem test.bat  
@echo off  
MainReturnValTest  
@if "%ERRORLEVEL%" == "0" goto good  
  
:fail  
    echo Execution Failed  
    echo return value = %ERRORLEVEL%  
    goto end  
  
:good  
    echo Execution succeeded  
    echo Return value = %ERRORLEVEL%  
    goto end  
  
:end  
```  
  
## Sample Output  
 `Execution succeeded`  
  
 `Return value = 0`  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Reference](../vs140/csharp-reference.md)   
 [Main() and Command Line Arguments (C#)](../vs140/main---and-command-line-arguments--csharp-programming-guide-.md)   
 [How to: Print Command Line Arguments (C#)](../vs140/how-to--display-command-line-arguments--csharp-programming-guide-.md)   
 [How to: Access Command Line Arguments using foreach (C#)](../vs140/how-to--access-command-line-arguments-using-foreach--csharp-programming-guide-.md)