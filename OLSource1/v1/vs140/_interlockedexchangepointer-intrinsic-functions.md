---
title: "_InterlockedExchangePointer Intrinsic Functions"
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
  - "_InterlockedExchangePointer_cpp"
  - "_InterlockedExchangePointer_rel"
  - "_InterlockedExchangePointer_nf"
  - "_InterlockedExchangePointer_HLERelease"
  - "_InterlockedExchangePointer_acq"
  - "_InterlockedExchangePointer"
  - "_InterlockedExchangePointer_acq_cpp"
  - "_InterlockedExchangePointer_HLEAcquire"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_InterlockedExchangePointer_rel intrinsic"
  - "_InterlockedExchangePointer_HLERelease intrinsic"
  - "_InterlockedExchangePointer intrinsic"
  - "_InterlockedExchangePointer_nf intrinsic"
  - "_InterlockedExchangePointer_acq intrinsic"
  - "_InterlockedExchangePointer_HLEAcquire intrinsic"
  - "InterlockedExchangePointer_acq intrinsic"
  - "InterlockedExchangePointer intrinsic"
ms.assetid: 0eaca0b0-d79e-406b-892d-b3b462c50bbb
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedExchangePointer Intrinsic Functions
**Microsoft Specific**  
  
 Perform an atomic exchange operation, which copies the address passed in as the second argument to the first and returns the original address of the first.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the pointer to the value to exchange. The function sets the value to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and returns its previous value.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Value to be exchanged with the value pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 The function returns the initial value pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|ARM|\<intrin.h>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] with HLE support|\<immintrin.h>|  
  
 On the x86 architecture, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a macro that calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 On a 64-bit system, the parameters are 64 bits and must be aligned on 64-bit boundaries; otherwise, the function fails. On a 32-bit system, the parameters are 32 bits and must be aligned on 32-bit boundaries. For more information, see [align](../vs140/align--c---.md).  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> suffixes if you need acquire and release semantics, such as at the beginning and end of a critical section. The intrinsic with an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> ("no fence") suffix does not act as a memory barrier.  
  
 On Intel platforms that support Hardware Lock Elision (HLE) instructions, the intrinsics with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> suffixes include a hint to the processor that can accelerate performance by eliminating a lock write step in hardware. If these intrinsics are called on platforms that do not support HLE, the hint is ignored.  
  
 These routines are only available as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)