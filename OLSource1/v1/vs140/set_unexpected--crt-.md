---
title: "set_unexpected (CRT)"
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
  - "set_unexpected"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_unexpected"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "set_unexpected function"
  - "unexpected function"
  - "exception handling, termination"
ms.assetid: ebcef032-4771-48e5-88aa-2a1ab8750aa6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_unexpected (CRT)
Installs your own termination function to be called by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a function that you write to replace the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function.  
  
## Return Value  
 Returns a pointer to the previous termination function registered by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> so that the previous function can be restored later. If no previous function has been set, the return value may be used to restore the default behavior; this value may be NULL.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function installs <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as the function called by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not used in the current C++ exception-handling implementation. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type is defined in EH.H as a pointer to a user-defined unexpected function, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Your custom <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function should not return to its caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 By default, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. You can change this default behavior by writing your own termination function and calling <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with the name of your function as its argument. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> calls the last function given as an argument to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 Unlike the custom termination function installed by a call to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, an exception can be thrown from within <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 In a multithreaded environment, unexpected functions are maintained separately for each thread. Each new thread needs to install its own unexpected function. Thus, each thread is in charge of its own unexpected handling.  
  
 In the current Microsoft implementation of C++ exception handling, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> by default and is never called by the exception-handling run-time library. There is no particular advantage to calling <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 There is a single <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> handler for all dynamically linked DLLs or EXEs; even if you call <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> your handler may be replaced by another or that you are replacing a handler set by another DLL or EXE.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<eh.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Exception Handling Routines](../vs140/exception-handling-routines.md)   
 [abort](../vs140/abort.md)   
 [_get_unexpected](../vs140/_get_unexpected.md)   
 [set_terminate](../vs140/set_terminate--crt-.md)   
 [terminate](../vs140/terminate--crt-.md)   
 [unexpected](../vs140/unexpected--crt-.md)