---
title: "atexit"
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
  - "atexit"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "atexit"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "processing, at exit"
  - "atexit function"
ms.assetid: 92c156d2-8052-4e58-96dc-00128baac6f9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atexit
Processes the specified function at exit.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Function to be called.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns 0 if successful, or a nonzero value if an error occurs.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function is passed the address of a function (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) to be called when the program terminates normally. Successive calls to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> create a register of functions that are executed in last-in, first-out (LIFO) order. The functions passed to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> cannot take parameters. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> use the heap to hold the register of functions. Thus, the number of functions that can be registered is limited only by heap memory.  
  
 The code in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function should not contain any dependency on any DLL which could have already been unloaded when the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function is called.  
  
 To generate an ANSI-compliant application, use the ANSI-standard <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function (rather than the similar <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
## Example  
 This program pushes four functions onto the stack of functions to be executed when <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is called. When the program exits, these programs are executed on a last in, first out basis.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **This is executed first.**  
**This is executed next.**   
## .NET Framework Equivalent  
 [System::Diagnostics::Process::Exited](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.exited.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [abort](../vs140/abort.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)