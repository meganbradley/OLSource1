---
title: "_InterlockedCompareExchangePointer Intrinsic Functions"
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
  - "_InterlockedCompareExchangePointer_HLERelease"
  - "_InterlockedCompareExchangePointer_rel"
  - "_InterlockedCompareExchangePointer_acq_cpp"
  - "_InterlockedCompareExchangePointer"
  - "_InterlockedCompareExchangePointer_cpp"
  - "_InterlockedCompareExchangePointer_np"
  - "_InterlockedCompareExchangePointer_rel_cpp"
  - "_InterlockedCompareExchangePointer_HLEAcquire"
  - "_InterlockedCompareExchangePointer_acq"
  - "_InterlockedCompareExchangePointer_nf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InterlockedCompareExchangePointer_acq intrinsic"
  - "_InterlockedCompareExchangePointer_rel intrinsic"
  - "_InterlockedCompareExchangePointer_acq intrinsic"
  - "InterlockedCompareExchangePointer_rel intrinsic"
  - "InterlockedCompareExchangePointer intrinsic"
  - "_InterlockedCompareExchangePointer_HLERelease intrinsic"
  - "_InterlockedCompareExchangePointer_HLEAcquire intrinsic"
  - "_InterlockedCompareExchangePointer intrinsic"
  - "_InterlockedCompareExchangePointer_nf intrinsic"
  - "_InterlockedCompareExchangePointer_np intrinsic"
ms.assetid: 97fde59d-2bf9-42aa-a0fe-a5b6befdd44b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedCompareExchangePointer Intrinsic Functions
**Microsoft Specific**  
  
 Performs an atomic operation that stores the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> address in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> address if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> address are equal.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a pointer to the destination value. The sign is ignored.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Exchange pointer. The sign is ignored.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to compare to destination. The sign is ignored.  
  
## Return Value  
 The return value is the initial value of the destination.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|ARM|\<iiintrin.h>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<immintrin.h>|  
  
## Remarks  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> performs an atomic comparison of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> address with the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> address. If the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> address is equal to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> address, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> address is stored in the address specified by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Otherwise, no operation is performed.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> provides compiler intrinsic support for the Win32 [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] [_InterlockedCompareExchangePointer](http://msdn.microsoft.com/library/ff547863.aspx) function.  
  
 For a example of how to use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, see [_InterlockedDecrement](../vs140/_interlockeddecrement-intrinsic-functions.md).  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> suffixes if you need acquire and release semantics, such as at the beginning and end of a critical section. ARM intrinsics with an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 The intrinsics with an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> ("no prefetch") suffix prevent a possible prefetch operation from being inserted by the compiler.  
  
 On Intel platforms that support Hardware Lock Elision (HLE) instructions, the intrinsics with <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> suffixes include a hint to the processor that can accelerate performance by eliminating a lock write step in hardware. If these intrinsics are called on platforms that do not support HLE, the hint is ignored.  
  
 These routines are only available as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)