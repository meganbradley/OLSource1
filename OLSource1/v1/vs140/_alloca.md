---
title: "_alloca"
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
  - "_alloca"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_alloca"
  - "alloca"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memory allocation, stack"
  - "alloca function"
  - "_alloca function"
ms.assetid: 74488eb1-b71f-4515-88e1-cdd03b6f8225
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _alloca
Allocates memory on the stack. This function is deprecated because a more secure version is available; see [_alloca_s](../vs140/_malloca.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Bytes to be allocated from the stack.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> routine returns a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer to the allocated space, which is guaranteed to be suitably aligned for storage of any type of object. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> allocates a zero-length item and returns a valid pointer to that item.  
  
 A stack overflow exception is generated if the space cannot be allocated. The stack overflow exception is not a C++ exception; it is a structured exception. Instead of using C++ exception handling, you must use [Structured Exception Handling](../vs140/structured-exception-handling--c-c---.md) (SEH).  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> allocates <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bytes from the program stack. The allocated space is automatically freed when the calling function exits (not when the allocation merely passes out of scope). Therefore, do not pass the pointer value returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as an argument to [free](../vs140/free.md).  
  
 There are restrictions to explicitly calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in an exception handler (EH). EH routines that run on x86-class processors operate in their own memory frame: They perform their tasks in memory space that is not based on the current location of the stack pointer of the enclosing function. The most common implementations include Windows NT structured exception handling (SEH) and C++ catch clause expressions. Therefore, explicitly calling <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in any of the following scenarios results in program failure during the return to the calling EH routine:  
  
-   Windows NT SEH exception filter expression: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> )  
  
-   Windows NT SEH final exception handler: <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> {<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> }  
  
-   C++ EH catch clause expression  
  
 However, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can be called directly from within an EH routine or from an application-supplied callback that gets invoked by one of the EH scenarios previously listed.  
  
> [!IMPORTANT]
>  In Windows XP, if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is called inside a try/catch block, you must call [_resetstkoflw](../vs140/_resetstkoflw.md) in the catch block.  
  
 In addition to the above restrictions, when using the[/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) option, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> cannot be used in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> blocks. For more information, see [/clr Restrictions](../vs140/-clr-restrictions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Allocated 1000 bytes of stack at 0x0012FB50**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [malloc](../vs140/malloc.md)   
 [realloc](../vs140/realloc.md)   
 [_resetstkoflw](../vs140/_resetstkoflw.md)   
 [_alloca_s](../vs140/_malloca.md)