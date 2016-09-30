---
title: "_set_new_handler"
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
  - "_set_new_handler"
apilocation: 
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_set_new_handler"
  - "set_new_handler"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_set_new_handler function"
  - "set_new_handler function"
  - "error handling"
  - "transferring control to error handler"
ms.assetid: 1d1781b6-5cf8-486a-b430-f365e0bb023f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_new_handler
Transfers control to your error-handling mechanism if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator fails to allocate memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the application-supplied memory handling function. An argument of 0 causes the new handler to be removed.  
  
## Return Value  
 Returns a pointer to the previous exception handling function registered by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, so that the previous function can be restored later. If no previous function has been set, the return value can be used to restore the default behavior; this value can be <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 The C++ <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function specifies an exception-handling function that gains control if the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operator fails to allocate memory. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> fails, the run-time system automatically calls the exception-handling function that was passed as an argument to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, defined in New.h, is a pointer to a function that returns type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and takes an argument of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to specify the amount of space to be allocated.  
  
 There is no default handler.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is essentially a garbage-collection scheme. The run-time system retries allocation each time your function returns a nonzero value and fails if your function returns 0.  
  
 An occurrence of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function in a program registers the exception-handling function specified in the argument list with the run-time system:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can save the function address that was last passed to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function and reinstate it later:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The C++ [_set_new_mode](../vs140/_set_new_mode.md) function sets the new handler mode for [malloc](../vs140/malloc.md). The new handler mode indicates whether, on failure, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is to call the new handler routine as set by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. By default, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> does not call the new handler routine on failure to allocate memory. You can override this default behavior so that, when <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> fails to allocate memory, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> calls the new handler routine in the same way that the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> operator does when it fails for the same reason. To override the default, call:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 early in your program or link with Newmode.obj.  
  
 If a user-defined <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>is provided, the new handler functions are not automatically called on failure.  
  
 For more information, see [new](../vs140/new-operator--c---.md) and [delete](../vs140/delete-operator--c---.md) in the *C++ Language Reference*.  
  
 There is a single <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> handler for all dynamically linked DLLs or executables; even if you call <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> your handler might be replaced by another or that you are replacing a handler set by another DLL or executable.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<new.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 In this example, when the allocation fails, control is transferred to MyNewHandler. The argument passed to MyNewHandler is the number of bytes requested. The value returned from MyNewHandler is a flag indicating whether allocation should be retried: a nonzero value indicates that allocation should be retried, and a zero value indicates that allocation has failed.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Allocation failed. Coalescing heap.**  
**This application has requested the Runtime to terminate it in an unusual way.**  
**Please contact the application's support team for more information.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [free](../vs140/free.md)   
 [realloc](../vs140/realloc.md)