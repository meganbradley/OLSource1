---
title: "_InterlockedOr Intrinsic Functions"
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
  - "_InterlockedOr8_nf"
  - "_InterlockedOr_HLEAcquire"
  - "_InterlockedOr16_nf"
  - "_InterlockedOr64"
  - "_InterlockedOr8_np"
  - "_InterlockedOr64_cpp"
  - "_InterlockedOr8_acq"
  - "_InterlockedOr_nf"
  - "_InterlockedOr64_acq"
  - "_InterlockedOr_np"
  - "_InterlockedOr8"
  - "_InterlockedOr"
  - "_InterlockedOr64_np"
  - "_InterlockedOr_acq"
  - "_InterlockedOr64_HLERelease"
  - "_InterlockedOr16_np"
  - "_InterlockedOr_cpp"
  - "_InterlockedOr8_rel"
  - "_InterlockedOr64_rel"
  - "_InterlockedOr16_acq"
  - "_InterlockedOr_rel"
  - "_InterlockedOr16_rel"
  - "_InterlockedOr_HLERelease"
  - "_InterlockedOr64_HLEAcquire"
  - "_InterlockedOr16"
  - "_InterlockedOr64_nf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_InterlockedOr_acq intrinsic"
  - "InterlockedOr64 intrinsic"
  - "_InterlockedOr_nf intrinsic"
  - "_InterlockedOr intrinsic"
  - "_InterlockedOr64_HLERelease intrinsic"
  - "_InterlockedOr8_rel intrinsic"
  - "_InterlockedOr8_np intrinsic"
  - "_InterlockedOr64_nf intrinsic"
  - "_InterlockedOr_HLERelease intrinsic"
  - "_InterlockedOr16_np intrinsic"
  - "InterlockedOr intrinsic"
  - "_InterlockedOr8_nf intrinsic"
  - "_InterlockedOr16_nf intrinsic"
  - "_InterlockedOr8_acq intrinsic"
  - "_InterlockedOr64 intrinsic"
  - "_InterlockedOr16 intrinsic"
  - "_InterlockedOr64_acq intrinsic"
  - "_InterlockedOr64_HLEAcquire intrinsic"
  - "_InterlockedOr_np intrinsic"
  - "_InterlockedOr64_rel intrinsic"
  - "_InterlockedOr64_np intrinsic"
  - "_InterlockedOr_rel intrinsic"
  - "_InterlockedOr8 intrinsic"
  - "_InterlockedOr16_acq intrinsic"
  - "_InterlockedOr16_rel intrinsic"
  - "_InterlockedOr_HLEAcquire intrinsic"
ms.assetid: 5f265240-7af8-44b7-b952-19f3a9c56186
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedOr Intrinsic Functions
**Microsoft Specific**  
  
 Perform an atomic bitwise or operation on a variable shared by multiple threads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the first operand, to be replaced by the result.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second operand.  
  
## Return Value  
 The original value pointed to by the first parameter.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|ARM|\<intrin.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<immintrin.h>|  
  
## Remarks  
 The number in the name of each function specifies the bit size of the arguments.  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> suffixes if you need acquire and release semantics, such as at the beginning and end of a critical section. The ARM intrinsics with an <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 The intrinsics with an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> ("no prefetch") suffix prevent a possible prefetch operation from being inserted by the compiler.  
  
 On Intel platforms that support Hardware Lock Elision (HLE) instructions, the intrinsics with <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> suffixes include a hint to the processor that can accelerate performance by eliminating a lock write step in hardware. If these intrinsics are called on platforms that do not support HLE, the hint is ignored.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0xffffff00 0xffff00 0xff00ff00**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)