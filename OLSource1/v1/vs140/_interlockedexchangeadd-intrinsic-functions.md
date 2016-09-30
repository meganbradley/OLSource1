---
title: "_InterlockedExchangeAdd Intrinsic Functions"
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
  - "_InterlockedExchangeAdd64_nf"
  - "_InterlockedExchangeAdd64_rel"
  - "_InterlockedExchangeAdd16_rel"
  - "_InterlockedExchangeAdd_acq"
  - "_InterlockedExchangeAdd_nf"
  - "_InterlockedExchangeAdd_rel"
  - "_InterlockedExchangeAdd8_acq"
  - "_InterlockedExchangeAdd16_nf"
  - "_InterlockedExchangeAdd_acq_cpp"
  - "_InterlockedExchangeAdd64_acq_cpp"
  - "_InterlockedExchangeAdd16_acq"
  - "_InterlockedExchangeAdd_HLERelease"
  - "_InterlockedExchangeAdd64_cpp"
  - "_InterlockedExchangeAdd64_HLERelease"
  - "_InterlockedExchangeAdd64_acq"
  - "_InterlockedExchangeAdd8"
  - "_InterlockedExchangeAdd64"
  - "_InterlockedExchangeAdd8_nf"
  - "_InterlockedExchangeAdd16"
  - "_InterlockedExchangeAdd64_rel_cpp"
  - "_InterlockedExchangeAdd_cpp"
  - "_InterlockedExchangeAdd8_rel"
  - "_InterlockedExchangeAdd_HLEAcquire"
  - "_InterlockedExchangeAdd64_HLEAcquire"
  - "_InterlockedExchangeAdd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_InterlockedExchangeAdd8_nf intrinsic"
  - "InterlockedExchangeAdd64_acq intrinsic"
  - "_InterlockedExchangeAdd8_acq intrinsic"
  - "_InterlockedExchangeAdd64 intrinsic"
  - "_InterlockedExchangeAdd intrinsic"
  - "_InterlockedExchangeAdd8_rel intrinsic"
  - "_InterlockedExchangeAdd_acq intrinsic"
  - "_InterlockedExchangeAdd_HLEAcquire intrinsic"
  - "_InterlockedExchangeAdd8 intrinsic"
  - "_InterlockedExchangeAdd_rel intrinsic"
  - "_InterlockedExchangeAdd64_HLERelease intrinsic"
  - "_InterlockedExchangeAdd64_nf intrinsic"
  - "InterlockedExchangeAdd_rel intrinsic"
  - "InterlockedExchangeAdd intrinsic"
  - "_InterlockedExchangeAdd_nf intrinsic"
  - "_InterlockedExchangeAdd16_rel intrinsic"
  - "InterlockedExchangeAdd_acq intrinsic"
  - "_InterlockedExchangeAdd64_HLEAcquire intrinsic"
  - "_InterlockedExchangeAdd16 intrinsic"
  - "_InterlockedExchangeAdd64_acq intrinsic"
  - "InterlockedExchangeAdd64_rel intrinsic"
  - "_InterlockedExchangeAdd16_acq intrinsic"
  - "InterlockedExchangeAdd64 intrinsic"
  - "_InterlockedExchangeAdd_HLERelease intrinsic"
  - "_InterlockedExchangeAdd16_nf intrinsic"
  - "_InterlockedExchangeAdd64_rel intrinsic"
ms.assetid: 25809e1f-9c60-4492-9f7c-0fb59c8d13d2
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedExchangeAdd Intrinsic Functions
**Microsoft Specific**  
  
 Provide compiler intrinsic support for the Win32 [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] [_InterlockedExchangeAdd Intrinsic Functions](../vs140/_interlockedexchangeadd-intrinsic-functions.md) function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value to be added to; replaced by the result of the addition.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to add.  
  
## Return Value  
 The return value is the initial value of the variable pointed to by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|ARM|\<intrin.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<immintrin.h>|  
  
## Remarks  
 There are several variations on <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> that vary based on the data types they involve and whether processor-specific acquire or release semantics is used.  
  
 While the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function operates on 32-bit integer values, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> operates on 8-bit integer values, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> operates on 16-bit integer values, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> operates on 64-bit integer values.  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> suffixes if you need acquire and release semantics, such as at the beginning and end of a critical section. The intrinsics with an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 On Intel platforms that support Hardware Lock Elision (HLE) instructions, the intrinsics with <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> suffixes include a hint to the processor that can accelerate performance by eliminating a lock write step in hardware. If these intrinsics are called on platforms that do not support HLE, the hint is ignored.  
  
 These routines are only available as intrinsics. Thus, they are intrinsic whether or not [/Oi](../vs140/-oi--generate-intrinsic-functions-.md) or [#pragma intrinsic](../vs140/intrinsic.md) is used. It is not possible to use [#pragma function](../vs140/function--c-c---.md) on these intrinsics.  
  
## Example  
 For a sample of how to use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, see [_InterlockedDecrement](../vs140/_interlockeddecrement-intrinsic-functions.md).  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)