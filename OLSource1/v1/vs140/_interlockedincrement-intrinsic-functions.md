---
title: "_InterlockedIncrement Intrinsic Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_InterlockedIncrement_acq"
  - "_InterlockedIncrement16_rel_cpp"
  - "_InterlockedIncrement16_cpp"
  - "_InterlockedIncrement64_rel"
  - "_InterlockedIncrement_rel"
  - "_InterlockedIncrement64_nf"
  - "_InterlockedIncrement16_acq_cpp"
  - "_InterlockedIncrement_rel_cpp"
  - "_InterlockedIncrement64"
  - "_InterlockedIncrement64_rel_cpp"
  - "_InterlockedIncrement16_nf"
  - "_InterlockedIncrement16_rel"
  - "_InterlockedIncrement16_acq"
  - "_InterlockedIncrement_nf"
  - "_InterlockedIncrement_acq_cpp"
  - "_InterlockedIncrement64_cpp"
  - "_InterlockedIncrement64_acq_cpp"
  - "_InterlockedIncrement"
  - "_InterlockedIncrement_cpp"
  - "_InterlockedIncrement64_acq"
  - "_InterlockedIncrement16"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_InterlockedIncrement64_rel intrinsic"
  - "_InterlockedIncrement16_rel intrinsic"
  - "InterlockedIncrement64_acq intrinsic"
  - "_InterlockedIncrement16 intrinsic"
  - "_InterlockedIncrement16_acq intrinsic"
  - "_InterlockedIncrement_nf intrinsic"
  - "_InterlockedIncrement_rel intrinsic"
  - "_InterlockedIncrement64_nf intrinsic"
  - "InterlockedIncrement_rel intrinsic"
  - "InterlockedIncrement_acq intrinsic"
  - "_InterlockedIncrement64_acq intrinsic"
  - "_InterlockedIncrement16_nf intrinsic"
  - "_InterlockedIncrement intrinsic"
  - "_InterlockedIncrement64 intrinsic"
  - "InterlockedIncrement64_rel intrinsic"
  - "InterlockedIncrement64 intrinsic"
  - "InterlockedIncrement16 intrinsic"
  - "_InterlockedIncrement_acq intrinsic"
  - "InterlockedIncrement intrinsic"
ms.assetid: 37700615-f372-438b-bcef-d76e11839482
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedIncrement Intrinsic Functions
**Microsoft Specific**  
  
 Provide compiler intrinsic support for the Win32 [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] [InterlockedIncrement](http://msdn.microsoft.com/library/ms683614.aspx) function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the variable to be incremented.  
  
## Return Value  
 The return value is the resulting incremented value.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|ARM|\<intrin.h>|  
  
## Remarks  
 There are several variations on <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that vary based on the data types they involve and whether processor-specific acquire or release semantics is used.  
  
 While the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function operates on 32-bit integer values, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> operates on 16-bit integer values and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operates on 64-bit integer values.  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> suffixes if you need acquire and release semantics, such as at the beginning and end of a critical section. The intrinsic with an <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> ("no fence") suffix does not act as a memory barrier.  
  
 The variable pointed to by the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter must be aligned on a 32-bit boundary; otherwise, this function fails on multiprocessor x86 systems and any non-x86 systems. For more information, see [align](../vs140/align--c---.md).  
  
 The Win32 function is declared in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 These routines are only available as intrinsics.  
  
## Example  
 For a sample of how to use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, see [_InterlockedDecrement](../vs140/_interlockeddecrement-intrinsic-functions.md).  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)