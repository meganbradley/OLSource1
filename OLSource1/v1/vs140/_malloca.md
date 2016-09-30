---
title: "_malloca"
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
  - "_malloca"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "malloca"
  - "_malloca"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memory allocation, stack"
  - "malloca function"
  - "_malloca function"
ms.assetid: 293992df-cfca-4bc9-b313-0a733a6bb936
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _malloca
Allocates memory on the stack. This is a version of [_alloca](../vs140/_alloca.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Bytes to be allocated from the stack.  
  
## Return Value  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> routine returns a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer to the allocated space, which is guaranteed to be suitably aligned for storage of any type of object. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> allocates a zero-length item and returns a valid pointer to that item.  
  
 A stack overflow exception is generated if the space cannot be allocated. The stack overflow exception is not a C++ exception; it is a structured exception. Instead of using C++ exception handling, you must use [Structured Exception Handling](../vs140/structured-exception-handling--c-c---.md) (SEH).  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> allocates <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bytes from the program stack or the heap if the request exceeds a certain size in bytes given by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The difference between <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> always allocates on the stack, regardless of the size. Unlike <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which does not require or permit a call to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to free the memory so allocated, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> requires the use of [_freea](../vs140/_freea.md) to free memory. In debug mode, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> always allocates memory from the heap.  
  
 There are restrictions to explicitly calling <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in an exception handler (EH). EH routines that run on x86-class processors operate in their own memory frame: They perform their tasks in memory space that is not based on the current location of the stack pointer of the enclosing function. The most common implementations include Windows NT structured exception handling (SEH) and C++ catch clause expressions. Therefore, explicitly calling <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in any of the following scenarios results in program failure during the return to the calling EH routine:  
  
-   Windows NT SEH exception filter expression: <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> )  
  
-   Windows NT SEH final exception handler: <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> {<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> }  
  
-   C++ EH catch clause expression  
  
 However, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> can be called directly from within an EH routine or from an application-supplied callback that gets invoked by one of the EH scenarios previously listed.  
  
> [!IMPORTANT]
>  In Windows XP, if <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is called inside a try/catch block, you must call [_resetstkoflw](../vs140/_resetstkoflw.md) in the catch block.  
  
 In addition to the above restrictions, when using the [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) option, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> cannot be used in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> blocks. For more information, see [/clr Restrictions](../vs140/-clr-restrictions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [malloc](../vs140/malloc.md)   
 [realloc](../vs140/realloc.md)   
 [_resetstkoflw](../vs140/_resetstkoflw.md)