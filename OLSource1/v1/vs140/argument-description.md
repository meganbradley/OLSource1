---
title: "Argument Description"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "envp argument"
  - "main function, syntax"
  - "arguments [C++], for main function"
  - "argv argument"
  - "argc argument"
ms.assetid: 91c2cbe3-9aca-4277-afa1-6137eb8fb704
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Argument Description
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameter in the **main** and **wmain** functions is an integer specifying how many arguments are passed to the program from the command line. Since the program name is considered an argument, the value of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is at least one.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is an array of pointers to null-terminated strings representing the program arguments. Each element of the array points to a string representation of an argument passed to **main** (or **wmain**). (For information about arrays, see [Array Declarations](../vs140/array-declarations.md).) The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter can be declared either as an array of pointers to type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) or as a pointer to pointers to type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). For **wmain**, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter can be declared either as an array of pointers to type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) or as a pointer to pointers to type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
 By convention, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>**[0]** is the command with which the program is invoked.  However, it is possible to spawn a process using [CreateProcess](http://msdn.microsoft.com/library/windows/desktop/ms682425) and if you use both the first and second arguments (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>**[0]** may not be the executable name; use [GetModuleFileName](http://msdn.microsoft.com/library/windows/desktop/ms683197) to retrieve the executable name.  
  
 The last pointer (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) is **NULL**. (See [getenv](../vs140/getenv--_wgetenv.md) in the *Run-Time Library Reference* for an alternative method for getting environment variable information.)  
  
 **Microsoft Specific**  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter is a pointer to an array of null-terminated strings that represent the values set in the user's environment variables. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter can be declared as an array of pointers to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) or as a pointer to pointers to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>). In a **wmain** function, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter can be declared as an array of pointers to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) or as a pointer to pointers to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>). The end of the array is indicated by a **NULL** \*pointer. Note that the environment block passed to **main** or **wmain** is a "frozen" copy of the current environment. If you subsequently change the environment via a call to _**putenv** or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the current environment (as returned by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> variables) will change, but the block pointed to by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> will not change. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> parameter is ANSI compatible in C, but not in C++.  
  
 **END Microsoft Specific**  
  
## See Also  
 [The main Function and Program Execution](../vs140/main-function-and-program-execution.md)