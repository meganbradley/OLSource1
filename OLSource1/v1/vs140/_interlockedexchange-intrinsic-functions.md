---
title: "_InterlockedExchange Intrinsic Functions"
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
  - "_InterlockedExchange_rel"
  - "_InterlockedExchange8_nf"
  - "_InterlockedExchange_acq_cpp"
  - "_InterlockedExchange_nf"
  - "_InterlockedExchange64_nf"
  - "_InterlockedExchange_HLEAcquire"
  - "_InterlockedExchange_cpp"
  - "_InterlockedExchange64_acq_cpp"
  - "_InterlockedExchange64_acq"
  - "_InterlockedExchange64_HLERelease"
  - "_InterlockedExchange8_acq"
  - "_InterlockedExchange16_acq"
  - "_InterlockedExchange"
  - "_InterlockedExchange64_HLEAcquire"
  - "_InterlockedExchange8"
  - "_InterlockedExchange64_rel"
  - "_InterlockedExchange_acq"
  - "_InterlockedExchange16"
  - "_InterlockedExchange16_rel"
  - "_InterlockedExchange16_nf"
  - "_InterlockedExchange64"
  - "_InterlockedExchange_HLERelease"
  - "_InterlockedExchange64_cpp"
  - "_InterlockedExchange8_rel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_InterlockedExchange8"
  - "_InterlockedExchange64 intrinsic"
  - "_InterlockedExchange_acq intrinsic"
  - "InterlockedExchange64 intrinsic"
  - "_InterlockedExchange64_acq intrinsic"
  - "InterlockedExchange64_acq intrinsic"
  - "_InterlockedExchange16_acq"
  - "_InterlockedExchange8_acq"
  - "_InterlockedExchange16"
  - "_InterlockedExchange8_rel"
  - "InterlockedExchange_acq intrinsic"
  - "InterlockedExchange intrinsic"
  - "_InterlockedExchange16_rel"
  - "_InterlockedExchange16_nf"
  - "_InterlockedExchange intrinsic"
  - "_InterlockedExchange8_nf"
ms.assetid: be2f232a-6301-462a-a92b-fcdeb8b0f209
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedExchange Intrinsic Functions
**Microsoft Specific**  
  
 Generates an atomic instruction to set a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the value to be exchanged. The function sets this variable to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and returns its prior value.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Value to be exchanged with the value pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns the initial value pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>,|ARM|\<intrin.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<immintrin.h>|  
  
## Remarks  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> provides compiler intrinsic support for the Win32 [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] [InterlockedExchange](http://msdn.microsoft.com/library/ms683590.aspx) function.  
  
 There are several variations on <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> that vary based on the data types they involve and whether processor-specific acquire or release semantics is used.  
  
 While the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function operates on 32-bit integer values, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> operates on 8-bit integer values, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> operates on 16-bit integer values, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operates on 64-bit integer values.  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> suffixes for acquire and release semantics, such as at the beginning and end of a critical section. The intrinsics with an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 On Intel platforms that support Hardware Lock Elision (HLE) instructions, the intrinsics with <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> suffixes include a hint to the processor that can accelerate performance by eliminating a lock write step in hardware. If these intrinsics are called on platforms that do not support HLE, the hint is ignored.  
  
 These routines are only available as intrinsics.  
  
## Example  
 For a sample of how to use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, see [_InterlockedDecrement](../vs140/_interlockeddecrement-intrinsic-functions.md).  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)