---
title: "assert Macro, _assert, _wassert"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "assert"
  - "_assert"
  - "_wassert"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-crt-runtime-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "assert"
  - "_assert"
  - "_wassert"
  - "assert/_wassert"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "aborting programs"
  - "assert function"
  - "assert macro"
ms.assetid: a9ca031a-648b-47a6-bdf1-65fc7399dd40
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# assert Macro, _assert, _wassert
Evaluates an expression and, when the result is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, prints a diagnostic message and aborts the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A scalar expression (including pointer expressions) that evaluates to nonzero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) or 0 (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The message to display.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The name of the source file the assertion failed in.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The line number in the source file of the failed assertion.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> macro is typically used to identify logic errors during program development. Use it to stop program execution when unexpected conditions occur by implementing the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument to evaluate to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> only when the program is operating incorrectly. Assertion checks can be turned off at compile time by defining the macro <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. You can turn off the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> macro without modifying your source files by using a **/DNDEBUG** command-line option. You can turn off the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> macro in your source code by using a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> directive before \<assert.h> is included.  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> macro prints a diagnostic message when <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (0) and calls [abort](../vs140/abort.md) to terminate program execution. No action is taken if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (nonzero). The diagnostic message includes the failed expression, the name of the source file and line number where the assertion failed.  
  
 The diagnostic message is printed in wide characters. Thus, it will work as expected even if there are Unicode characters in the expression.  
  
 The destination of the diagnostic message depends on the type of application that called the routine. Console applications always receive the message through <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. In a Windows-based application, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> calls the Windows [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505) function to create a message box to display the message along with an **OK** button. When the user clicks **OK**, the program aborts immediately.  
  
 When the application is linked with a debug version of the run-time libraries, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> creates a message box with three buttons: **Abort**, **Retry**, and **Ignore**. If the user clicks **Abort**, the program aborts immediately. If the user clicks **Retry**, the debugger is called and the user can debug the program if just-in-time (JIT) debugging is enabled. If the user clicks **Ignore**, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> continues with its normal execution: creating the message box with the **OK** button. Note that clicking **Ignore** when an error condition exists can result in undefined behavior.  
  
 For more information about CRT debugging, see [CRT Debugging Techniques](../vs140/crt-debugging-techniques.md).  
  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> functions are internal CRT functions. They help minimize the code required in your object files to support assertions. We do not recommend that you call these functions directly.  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> macro is enabled in both the release and debug versions of the C run-time libraries when <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is not defined. When <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is defined, the macro is available but does not evaluate its argument and has no effect. When it is enabled, the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> macro calls <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> for its implementation. Other assertion macros, [_ASSERT](../vs140/_assert--_asserte--_assert_expr-macros.md), [_ASSERTE](../vs140/_assert--_asserte--_assert_expr-macros.md) and [_ASSERT_EXPR](../vs140/_assert--_asserte--_assert_expr-macros.md), are also available, but they only evaluate the expressions passed to them when the [_DEBUG](../vs140/_debug.md) macro has been defined and when they are in code linked with the debug version of the C run-time libraries.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<assert.h>|  
  
 The signature of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> function is not available in a header file. The signature of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> function is only available when the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> macro is not defined.  
  
## Example  
 In this program, the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> function uses the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> macro to test several conditions related to string and length. If any of the conditions fails, the program prints a message indicating what caused the failure.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The program generates this output:  
  
 **Analyzing string 'abc'**  
**Analyzing string '(null)'**  
**Assertion failed: string != NULL, file crt_assert.c, line 25** After the assertion failure, depending on the version of the operating system and run-time library, you may see a message box that contains something like the following:  
  
 **A problem caused the program to stop working correctly. Windows will close the program and notify you if a solution is available.** If a debugger is installed, choose the **Debug** button to start the debugger, or **Close program** to exit.  
  
## .NET Framework Equivalent  
 [System::Diagnostics::Debug::Assert](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.assert.aspx)  
  
## See Also  
 [Error Handling](../vs140/error-handling--crt-.md)   
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [abort](../vs140/abort.md)   
 [raise](../vs140/raise.md)   
 [signal](../vs140/signal.md)   
 [_ASSERT, _ASSERTE, _ASSERT_EXPR Macros](../vs140/_assert--_asserte--_assert_expr-macros.md)   
 [_DEBUG](../vs140/_debug.md)