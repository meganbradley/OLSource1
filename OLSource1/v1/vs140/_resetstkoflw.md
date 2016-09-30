---
title: "_resetstkoflw"
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
  - "_resetstkoflw"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "resetstkoflw"
  - "_resetstkoflw"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "resetstkoflw function"
  - "stack overflow"
  - "stack, recovering"
  - "_resetstkoflw function"
ms.assetid: 319529cd-4306-4d22-810b-2063f3ad9e14
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _resetstkoflw
Recovers from stack overflow.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the function succeeds, zero if it fails.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function recovers from a stack overflow condition, allowing a program to continue instead of failing with a fatal exception error. If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function is not called, there are no guard pages after the previous exception. The next time that there is a stack overflow, there are no exceptions at all and the process terminates without warning.  
  
 If a thread in an application causes an **EXCEPTION_STACK_OVERFLOW** exception, the thread has left its stack in a damaged state. This is in contrast to other exceptions such as **EXCEPTION_ACCESS_VIOLATION** or **EXCEPTION_INT_DIVIDE_BY_ZERO**, where the stack is not damaged. The stack is set to an arbitrarily small value when the program is first loaded. The stack then grows on demand to meet the needs of the thread. This is implemented by placing a page with PAGE_GUARD access at the end of the current stack. For more information, see [Creating Guard Pages](http://msdn.microsoft.com/library/windows/desktop/aa366549).  
  
 When the code causes the stack pointer to point to an address on this page, an exception occurs and the system does the following three things:  
  
-   Removes the PAGE_GUARD protection on the guard page so that the thread can read and write data to the memory.  
  
-   Allocates a new guard page that is located one page below the last one.  
  
-   Reruns the instruction that raised the exception.  
  
 In this way, the system can increase the size of the stack for the thread automatically. Each thread in a process has a maximum stack size. The stack size is set at compile time by the [/STACK (Stack Allocations)](../vs140/-stack--stack-allocations-.md), or by the [STACKSIZE](../vs140/stacksize.md) statement in the .def file for the project.  
  
 When this maximum stack size is exceeded, the system does the following three things:  
  
-   Removes the PAGE_GUARD protection on the guard page, as previously described.  
  
-   Tries to allocate a new guard page below the last one. However, this fails because the maximum stack size has been exceeded.  
  
-   Raises an exception so that the thread can handle it in the exception block.  
  
 Note that, at that point, the stack no longer has a guard page. The next time that the program grows the stack all the way to the end, where there should be a guard page, the program writes beyond the end of the stack and causes an access violation.  
  
 Call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to restore the guard page whenever recovery is done after a stack overflow exception. This function can be called from inside the main body of an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block or outside an **__except** block. However, there are some restrictions on when it should be used. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> should never be called from:  
  
-   A filter expression.  
  
-   A filter function.  
  
-   A function called from a filter function.  
  
-   A **catch** block.  
  
-   A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block.  
  
 At these points, the stack is not yet sufficiently unwound.  
  
 Stack overflow exceptions are generated as structured exceptions, not C++ exceptions, so <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not useful in an ordinary **catch** block because it will not catch a stack overflow exception. However, if [_set_se_translator](../vs140/_set_se_translator.md) is used to implement a structured exception translator that throws C++ exceptions (as in the second example), a stack overflow exception results in a C++ exception that can be handled by a C++ catch block.  
  
 It is not safe to call **_resetstkoflw** in a C++ catch block that is reached from an exception thrown by the structured exception translator function. In this case, the stack space is not freed and the stack pointer is not reset until outside the catch block, even though destructors have been called for any destructible objects before the catch block. This function should not be called until the stack space is freed and the stack pointer has been reset. Therefore, it should be called only after exiting the catch block. As little stack space as possible should be used in the catch block because a stack overflow that occurs in the catch block that is itself attempting to recover from a previous stack overflow is not recoverable and can cause the program to stop responding as the overflow in the catch block triggers an exception that itself is handled by the same catch block.  
  
 There are situations where **_resetstkoflw** can fail even if used in a correct location, such as within an **__except** block. If, even after unwinding the stack, there is still not enough stack space left to execute **_resetstkoflw** without writing into the last page of the stack, **_resetstkoflw** fails to reset the last page of the stack as the guard page and returns 0, indicating failure. Therefore, safe usage of this function should include checking the return value instead of assuming that the stack is safe to use.  
  
 Structured exception handling will not catch a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> exception when the application is compiled with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (see [/clr topic](../vs140/-clr--common-language-runtime-compilation-.md)).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<malloc.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
 **Libraries:** All versions of the [CRT Library Features](../vs140/crt-library-features.md).  
  
## Example  
 The following example shows the recommended usage of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
 With no program arguments:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The program stops responding without executing further iterations.  
  
 With program arguments:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Description  
 The following example shows the recommended use of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in a program where structured exceptions are converted to C++ exceptions.  
  
### Code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_alloca](../vs140/_alloca.md)