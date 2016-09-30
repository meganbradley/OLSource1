---
title: "_InterlockedCompareExchange Intrinsic Functions"
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
  - "_InterlockedCompareExchange_HLERelease"
  - "_InterlockedCompareExchange8_nf"
  - "_InterlockedCompareExchange16_acq_cpp"
  - "_InterlockedCompareExchange_acq_cpp"
  - "_InterlockedCompareExchange16_rel_cpp"
  - "_InterlockedCompareExchange64_rel_cpp"
  - "_InterlockedCompareExchange_cpp"
  - "_InterlockedCompareExchange16_cpp"
  - "_InterlockedCompareExchange64_acq_cpp"
  - "_InterlockedCompareExchange_acq"
  - "_InterlockedCompareExchange64_rel"
  - "_InterlockedCompareExchange64_nf"
  - "_InterlockedCompareExchange_rel_cpp"
  - "_InterlockedCompareExchange16_nf"
  - "_InterlockedCompareExchange8"
  - "_InterlockedCompareExchange64_np"
  - "_InterlockedCompareExchange16_rel"
  - "_InterlockedCompareExchange64_acq"
  - "_InterlockedCompareExchange8_rel"
  - "_InterlockedCompareExchange_HLEAcquire"
  - "_InterlockedCompareExchange64_HLERelease"
  - "_InterlockedCompareExchange64_cpp"
  - "_InterlockedCompareExchange_np"
  - "_InterlockedCompareExchange8_acq"
  - "_InterlockedCompareExchange16_acq"
  - "_InterlockedCompareExchange_rel"
  - "_InterlockedCompareExchange64_HLEAcquire"
  - "_InterlockedCompareExchange64"
  - "_InterlockedCompareExchange16"
  - "_InterlockedCompareExchange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_InterlockedCompareExchange16 intrinsic"
  - "_InterlockedCompareExchange_acq intrinsic"
  - "InterlockedCompareExchange_acq intrinsic"
  - "_InterlockedCompareExchange intrinsic"
  - "InterlockedCompareExchange64 intrinsic"
  - "_InterlockedCompareExchange64_acq intrinsic"
  - "InterlockedCompareExchange16 intrinsic"
  - "_InterlockedCompareExchange_rel intrinsic"
  - "InterlockedCompareExchange intrinsic"
  - "InterlockedCompareExchange64_acq intrinsic"
  - "InterlockedCompareExchange_rel intrinsic"
  - "_InterlockedCompareExchange64 intrinsic"
  - "InterlockedCompareExchange64_rel intrinsic"
  - "_InterlockedCompareExchange64_rel intrinsic"
ms.assetid: c3ad79c0-a523-4930-a3a4-69a65d7d5c81
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedCompareExchange Intrinsic Functions
**Microsoft Specific**  
  
 Performs an interlocked compare and exchange.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the destination value. The sign is ignored.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Exchange value. The sign is ignored.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Value to compare to destination. The sign is ignored.  
  
## Return Value  
 The return value is the initial value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>,|ARM|\<intrin.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<immintrin.h>|  
  
## Remarks  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> performs an atomic comparison of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> value. If the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> value is equal to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> value, the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value is stored in the address specified by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. Otherwise, no operation is performed.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> provides compiler intrinsic support for the Win32 [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] [InterlockedCompareExchange](http://msdn.microsoft.com/library/ms683560.aspx) function.  
  
 There are several variations on <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> that vary based on the data types they involve and whether processor-specific acquire or release semantics is used.  
  
 While the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> function operates on long integer values, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> operates on 8-bit integer values, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> operates on short integer values and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> operates on 64-bit integer values.  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> suffixes for acquire and release semantics, such as at the beginning and end of a critical section. The ARM intrinsics with an <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 The intrinsics with an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> ("no prefetch") suffix prevent a possible prefetch operation from being inserted by the compiler.  
  
 On Intel platforms that support Hardware Lock Elision (HLE) instructions, the intrinsics with <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> suffixes include a hint to the processor that can accelerate performance by eliminating a lock write step in hardware. If these intrinsics are called on platforms that do not support HLE, the hint is ignored.  
  
 These routines are only available as intrinsics.  
  
## Example  
 In the following example, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is used for simple low-level thread synchronization. The approach has its limitations as a basis for multithreaded programming; it is presented to illustrate the typical use of the interlocked intrinsics. For best results, use the Windows API. For further information about multithreaded programming, see [Writing a Multithreaded Win32 Program](../vs140/writing-a-multithreaded-win32-program.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **<0**  
**<1**  
**<2**  
**<3**  
**<4**  
**<5**  
**<6**  
**<7**  
**<8**  
**<9**  
**<10**  
**<11**  
**<12**  
**<13**  
**<14**  
**<15**  
**<16**  
**<17**  
**<18**  
**<19**  
**<20**  
**<21**  
**<22**  
**<23**  
**<24**  
**<25**  
**<26**  
**<27**  
**<28**  
**<29**   
## END Microsoft Specific  
  
## See Also  
 [_InterlockedCompareExchange128](../vs140/_interlockedcompareexchange128.md)   
 [_InterlockedCompareExchangePointer Intrinsic Functions](../vs140/_interlockedcompareexchangepointer-intrinsic-functions.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)