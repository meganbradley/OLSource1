---
title: "setjmp"
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
  - "setjmp"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "setjmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "programs [C++], saving states"
  - "current state"
  - "setjmp function"
ms.assetid: 684a8b27-e8eb-455b-b4a8-733ca1cbd7d2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setjmp
Saves the current state of the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Variable in which environment is stored.  
  
## Return Value  
 Returns 0 after saving the stack environment. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns as a result of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> call, it returns the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns 1. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function saves a stack environment, which you can subsequently restore, using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. When used together, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> provide a way to execute a non-local <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. They are typically used to pass execution control to error-handling or recovery code in a previously called routine without using the normal calling or return conventions.  
  
 A call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> saves the current stack environment in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. A subsequent call to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> restores the saved environment and returns control to the point just after the corresponding <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> call. All variables (except register variables) accessible to the routine receiving control contain the values they had when <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> was called.  
  
 It is not possible to use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to jump from native to managed code.  
  
 **Note** <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> do not support C++ object semantics. In C++ programs, use the C++ exception-handling mechanism.  
  
 For more information, see [Using setjmp and longjmp](../vs140/using-setjmp-longjmp.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<setjmp.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [_fpreset](../vs140/_fpreset.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [longjmp](../vs140/longjmp.md)   
 [_setjmp3](../vs140/_setjmp3.md)