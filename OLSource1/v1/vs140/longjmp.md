---
title: "longjmp"
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
  - "longjmp"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "longjmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "restoring stack environment and execution locale"
  - "longjmp function"
ms.assetid: 0e13670a-5130-45c1-ad69-6862505b7a2f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# longjmp
Restores stack environment and execution locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Variable in which environment is stored.  
  
 *value*  
 Value to be returned to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> call.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function restores a stack environment and execution locale previously saved in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> provide a way to execute a nonlocal <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; they are typically used to pass execution control to error-handling or recovery code in a previously called routine without using the normal call and return conventions.  
  
 A call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> causes the current stack environment to be saved in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. A subsequent call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> restores the saved environment and returns control to the point immediately following the corresponding <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> call. Execution resumes as if *value* had just been returned by the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> call. The values of all variables (except register variables) that are accessible to the routine receiving control contain the values they had when <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> was called. The values of register variables are unpredictable. The value returned by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must be nonzero. If *value* is passed as 0, the value 1 is substituted in the actual return.  
  
 Call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> before the function that called <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> returns; otherwise the results are unpredictable.  
  
 Observe the following restrictions when using <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>:  
  
-   Do not assume that the values of the register variables will remain the same. The values of register variables in the routine calling <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> may not be restored to the proper values after <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is executed.  
  
-   Do not use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to transfer control out of an interrupt-handling routine unless the interrupt is caused by a floating-point exception. In this case, a program may return from an interrupt handler via <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if it first reinitializes the floating-point math package by calling <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
     **Note** Be careful when using <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in C++ programs. Because these functions do not support C++ object semantics, it is safer to use the C++ exception-handling mechanism.  
  
 For more information, see [Using setjmp and longjmp](../vs140/using-setjmp-longjmp.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<setjmp.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
 See the example for [_fpreset](../vs140/_fpreset.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [setjmp](../vs140/setjmp.md)