---
title: "Pseudovariables"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Watch window, pseudovariables"
  - "debugging [Visual Studio], pseudovariables"
  - "pseudovariables"
ms.assetid: fae84f68-2138-4144-9bd4-c9e271b6182a
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Pseudovariables
Pseudovariables are terms used to display certain information in a variable window or the **QuickWatch** dialog box. You can enter a pseudovariable the same way you would enter a normal variable. Pseudovariables are not variables, however, and do not correspond to variable names in your program.  
  
## Example  
 Suppose you are writing a native code application and want to see the number of handles allocated in your application. In the **Watch** window, you can enter the following pseudovariable in the **Name** column, then press Return to evaluate it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In native code, you can use the pseudovariables shown in this table:  
  
|Pseudovariable|Function|  
|--------------------|--------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Displays the last error value set with the function SetLastError. The value that is displayed represents what would be returned by the GetLastError function.\<br />\<br /> Use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to see the decoded form of this value. For example, if the last error was 3, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> would display <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Displays the number of handles allocated in your application.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Displays the address of the current stack frame.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Displays the thread ID for the current thread.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Displays the environment block in the string viewer.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Displays the command line string that launched the program.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Displays the process id.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> *registername*\<br />\<br /> or\<br />\<br /> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> *registername*|Displays the contents of the register *registername*.\<br />\<br /> Normally, you can display register contents just by entering the register name. The only time you need to use this syntax is when the register name overloads a variable name. If the register name is the same as a variable name in the current scope, the debugger interprets the name as a variable name. That's when <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>*registername* or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>*registername* comes in handy.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Displays the time in clock cycles.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Displays a structure with account information for the account running the application. For security reasons, the password information is not displayed.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Displays the stack trace of the current Windows Runtime exception. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> works only in Store apps that are running on Windows 8.1 or later. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is not supported for C++ and SHE exceptions|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Displays the return value of a .NET Framework method. See [Examine return values of method calls](../vs140/examine-return-values-of-method-calls.md)|  
  
 In C# and Visual Basic, you can use the pseudovariables shown in this table:  
  
|Pseudovariable|Function|  
|--------------------|--------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Displays information on the last exception. If no exception has occurred, evaluating <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> displays an error message.\<br />\<br /> In Visual C# only, when the Exception Assistant is disabled, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is automatically added to the **Locals** window when an exception occurs.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Displays a structure with account information for the account running the application. For security reasons, the password information is not displayed.|  
  
 In Visual Basic, you can use the pseudovariables shown in the following table:  
  
|Pseudovariable|Function|  
|--------------------|--------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Deletes an implicit variable that was created in the **Immediate** window. The syntax is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> *variable* or<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> *variable*<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Displays all active Object IDs as children of the specified expression. The syntax is <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> *expression* or<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> *expression*<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> *N* <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Displays object with Object ID equal to *N*.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Displays the special **Dynamic View** node for an object that implements the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. Interface. The syntax is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> *object*. This feature applies only to code that uses .NET Framework version 4. See [Dynamic View](../vs140/dynamic-view.md).|  
  
## See Also  
 [How to: Watch an Expression in the Debugger](../vs140/watch-and-quickwatch-windows.md)   
 [Debugger Variable Windows](../vs140/variable-windows.md)