---
title: "Argument Definitions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "envp argument"
  - "main function, arguments"
  - "arguments [C++], for main function"
  - "argv argument"
  - "argc argument"
ms.assetid: 6148cbf3-ebe8-44f2-b277-de4b723991c7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Argument Definitions
The arguments in the prototype  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 allow convenient command-line parsing of arguments and, optionally, access to environment variables. The argument definitions are as follows:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An integer that contains the count of arguments that follow in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is always greater than or equal to 1.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An array of null-terminated strings representing command-line arguments entered by the user of the program. By convention, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>**[0]** is the command with which the program is invoked, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>**[1]** is the first command-line argument, and so on, until <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>**[**<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**]**, which is always **NULL**. See [Customizing Command Line Processing](../vs140/customizing-c---command-line-processing.md) for information on suppressing command-line processing.  
  
 The first command-line argument is always <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>**[1]** and the last one is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>**[**<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> – 1**]**.  
  
> [!NOTE]
>  By convention, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>**[0]** is the command with which the program is invoked.  However, it is possible to spawn a process using [CreateProcess](http://msdn.microsoft.com/library/windows/desktop/ms683197) and if you use both the first and second arguments (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>**[0]** may not be the executable name; use [GetModuleFileName](http://msdn.microsoft.com/library/windows/desktop/ms683197) to retrieve the executable name, and its fully-qualified path.  
  
## Microsoft Specific  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> array, which is a common extension in many UNIX systems, is used in Microsoft C++. It is an array of strings representing the variables set in the user's environment. This array is terminated by a **NULL** entry. It can be declared as an array of pointers to **char (char** \*envp[ ]**)** or as a pointer to pointers to **char (char** \*\*envp**)**. If your program uses **wmain** instead of **main**, use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> data type instead of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The environment block passed to **main** and **wmain** is a "frozen" copy of the current environment. If you subsequently change the environment via a call to **putenv** or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the current environment (as returned by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>/ <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> variable) will change, but the block pointed to by envp will not change. See [Customizing Command Line Processing](../vs140/customizing-c---command-line-processing.md) for information on suppressing environment processing. This argument is ANSI compatible in C, but not in C++.  
  
## END Microsoft Specific  
  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> arguments to **main**:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [main: Program Startup](../vs140/main--program-startup.md)