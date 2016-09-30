---
title: "_interlockedbittestandreset Intrinsic Functions"
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
  - "_interlockedbittestandreset_rel"
  - "_interlockedbittestandreset64"
  - "_interlockedbittestandreset64_HLERelease"
  - "_interlockedbittestandreset_HLERelease"
  - "_interlockedbittestandreset_HLEAcquire"
  - "_interlockedbittestandreset_acq"
  - "_interlockedbittestandreset_cpp"
  - "_interlockedbittestandreset_nf"
  - "_interlockedbittestandreset64_cpp"
  - "_interlockedbittestandreset64_HLEAcquire"
  - "_interlockedbittestandreset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lock_btr instruction"
  - "_interlockedbittestandreset64 intrinsic"
  - "_interlockedbittestandreset intrinsic"
ms.assetid: 9bbb1442-f2e9-4dc2-b0da-97f3de3493b9
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _interlockedbittestandreset Intrinsic Functions
**Microsoft Specific**  
  
 Generates an instruction which sets bit <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> of the address <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to zero and returns its original value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the memory to examine.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The bit position to test.  
  
## Return Value  
 The original value of the bit at the position specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|ARM|\<intrin.h>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<immintrin.h>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<immintrin.h>|  
  
## Remarks  
 On x86 and [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] processors, these intrinsics use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> instruction, that reads and sets the specified bit to zero in an atomic operation.  
  
 On ARM processors, use the intrinsics with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> suffixes for acquire and release semantics, such as at the beginning and end of a critical section. The ARM intrinsics with an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 On Intel processors that support Hardware Lock Elision (HLE) instructions, the intrinsics with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> suffixes include a hint to the processor that can accelerate performance by eliminating a lock write step in hardware. If these intrinsics are called on processors that do not support HLE, the hint is ignored.  
  
 These routines are only available as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)