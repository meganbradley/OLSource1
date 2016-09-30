---
title: "set_terminate (CRT)"
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
  - "set_terminate"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_terminate"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "set_terminate function"
  - "terminate function"
  - "exception handling, termination"
ms.assetid: 3ff1456a-7898-44bc-9266-a328a80b6006
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_terminate (CRT)
Installs your own termination routine to be called by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a terminate function that you write.  
  
## Return Value  
 Returns a pointer to the previous function registered by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> so that the previous function can be restored later. If no previous function has been set, the return value may be used to restore the default behavior; this value may be NULL.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function installs <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as the function called by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is used with C++ exception handling and may be called at any point in your program before the exception is thrown. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> by default. You can change this default by writing your own termination function and calling <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with the name of your function as its argument. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> calls the last function given as an argument to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. After performing any desired cleanup tasks, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> should exit the program. If it does not exit (if it returns to its caller), <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is called.  
  
 In a multithreaded environment, terminate functions are maintained separately for each thread. Each new thread needs to install its own terminate function. Thus, each thread is in charge of its own termination handling.  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> type is defined in EH.H as a pointer to a user-defined termination function, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Your custom function <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can take no arguments and should not return to its caller. If it does, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is called. An exception may not be thrown from within <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function only works outside the debugger.  
  
 There is a single <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> handler for all dynamically linked DLLs or EXEs; even if you call <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> your handler may be replaced by another, or you may be replacing a handler set by another DLL or EXE.  
  
 This function is not supported under **/clr:pure**.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<eh.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [terminate](../vs140/terminate--crt-.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Exception Handling Routines](../vs140/exception-handling-routines.md)   
 [abort](../vs140/abort.md)   
 [_get_terminate](../vs140/_get_terminate.md)   
 [set_unexpected](../vs140/set_unexpected--crt-.md)   
 [terminate](../vs140/terminate--crt-.md)   
 [unexpected](../vs140/unexpected--crt-.md)