---
title: "_CrtSetAllocHook"
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
  - "_CrtSetAllocHook"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_CrtSetAllocHook"
  - "CrtSetAllocHook"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CrtSetAllocHook function"
  - "CrtSetAllocHook function"
ms.assetid: 405df37b-2fd1-42c8-83bc-90887f17f29d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtSetAllocHook
Installs a client-defined allocation function by hooking it into the C run-time debug memory allocation process (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 New client-defined allocation function to hook into the C run-time debug memory allocation process.  
  
## Return Value  
 Returns the previously defined allocation hook function, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> allows an application to hook its own allocation function into the C run-time debug library memory allocation process. As a result, every call to a debug allocation function to allocate, reallocate, or free a memory block triggers a call to the application's hook function. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> provides an application with an easy method for testing how the application handles insufficient memory situations, the ability to examine allocation patterns, and the opportunity to log allocation information for later analysis. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function installs the new client-defined allocation function specified in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and returns the previously defined hook function. The following example demonstrates how a client-defined allocation hook should be prototyped:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument specifies the type of allocation operation <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) that triggered the call to the allocation's hook function. When the triggering allocation type is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a pointer to the user data section of the memory block about to be freed. However, when the triggering allocation type is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> because the memory block has not been allocated yet.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> specifies the size of the memory block in bytes, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> indicates the type of the memory block, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is the object allocation order number of the memory block, and, if available, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> specify the source file name and line number where the triggering allocation operation was initiated.  
  
 After the hook function has finished processing, it must return a Boolean value, which tells the main C run-time allocation process how to continue. When the hook function wants the main allocation process to continue as if the hook function had never been called, then the hook function should return <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. This causes the original triggering allocation operation to be executed. Using this implementation, the hook function can gather and save allocation information for later analysis, without interfering with the current allocation operation or state of the debug heap.  
  
 When the hook function wants the main allocation process to continue as if the triggering allocation operation was called and it failed, then the hook function should return <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. Using this implementation, the hook function can simulate a wide range of memory conditions and debug heap states to test how the application handles each situation.  
  
 To clear the hook function, pass <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 For more information about how <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> can be used with other memory management functions or how to write your own client-defined hook functions, see [Debug Hook Function Writing](../vs140/debug-hook-function-writing.md).  
  
> [!NOTE]
>  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is not supported under <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 For a sample of how to use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, see [crt_dbg2](assetId:///21e1346a-6a17-4f57-b275-c76813089167).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_CrtGetAllocHook](../vs140/_crtgetallochook.md)