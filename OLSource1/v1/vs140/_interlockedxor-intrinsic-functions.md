---
title: "_InterlockedXor Intrinsic Functions"
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
  - "_InterlockedXor_nf"
  - "_InterlockedXor_np"
  - "_InterlockedXor64_HLERelease"
  - "_InterlockedXor8_acq"
  - "_InterlockedXor64_acq"
  - "_InterlockedXor64_rel"
  - "_InterlockedXor64_nf"
  - "_InterlockedXor_acq"
  - "_InterlockedXor16"
  - "_InterlockedXor64_np"
  - "_InterlockedXor64"
  - "_InterlockedXor_HLEAcquire"
  - "_InterlockedXor_HLERelease"
  - "_InterlockedXor_cpp"
  - "_InterlockedXor16_rel"
  - "_InterlockedXor8_rel"
  - "_InterlockedXor8"
  - "_InterlockedXor64_HLEAcquire"
  - "_InterlockedXor16_nf"
  - "_InterlockedXor16_acq"
  - "_InterlockedXor16_np"
  - "_InterlockedXor8_fn"
  - "_InterlockedXor8_np"
  - "_InterlockedXor64_cpp"
  - "_InterlockedXor_rel"
  - "_InterlockedXor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InterlockedXor intrinsic"
  - "_InterlockedXor64 intrinsic"
  - "InterlockedXor64 intrinsic"
  - "_InterlockedXor intrinsic"
ms.assetid: faef1796-cb5a-4430-b1e2-9d5eaf9b4a91
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedXor Intrinsic Functions
**Microsoft Specific**  
  
 Perform an atomic bitwise exclusive or (XOR) operation on a variable shared by multiple threads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the first operand, to be replaced by the result.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second operand.  
  
## Return Value  
 The original value of the first operand.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>,|ARM|\<intrin.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<immintrin.h>|  
  
## Remarks  
 The number in the name of each function specifies the bit size of the arguments.  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> suffixes if you need acquire and release semantics, such as at the beginning and end of a critical section. The ARM intrinsics with an <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 The intrinsics with an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> ("no prefetch") suffix prevent a possible prefetch operation from being inserted by the compiler.  
  
 On Intel platforms that support Hardware Lock Elision (HLE) instructions, the intrinsics with <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> suffixes include a hint to the processor that can accelerate performance by eliminating a lock write step in hardware. If these intrinsics are called on platforms that do not support HLE, the hint is ignored.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0xffff0000 0xffff00 0xff00ff00**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)