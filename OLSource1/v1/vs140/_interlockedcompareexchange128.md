---
title: "_InterlockedCompareExchange128"
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
  - "_InterlockedCompareExchange128_cpp"
  - "_InterlockedCompareExchange128"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cmpxchg16b instruction"
  - "_InterlockedCompareExchange128 intrinsic"
ms.assetid: f05918fc-716a-4f6d-b746-1456d6b96c56
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedCompareExchange128
**Microsoft Specific**  
  
 Performs a 128-bit interlocked compare and exchange.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the destination, which is an array of two 64-bit integers considered as a 128-bit field. The destination data must be 16-byte aligned to avoid a general protection fault.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A 64-bit integer that may be exchanged with the high part of the destination.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A 64-bit integer that may be exchanged with the low part of the destination.  
  
 [in, out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to an array of two 64-bit integers (considered as a 128-bit field) to compare with the destination.  On output, this is overwritten with the original value of the destination.  
  
## Return Value  
 1 if the 128-bit comparand equals the original value of the destination. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> overwrite the 128-bit destination.  
  
 0 if the comparand does not equal the original value of the destination. The value of the destination is unchanged and the value of the comparand is overwritten with the value of the destination.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This intrinsic generates the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instruction (with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> prefix) to perform a 128-bit locked compare and exchange. Early versions of AMD 64-bit hardware do not support this instruction. To check for hardware support for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> instruction, call the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> intrinsic with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Bit 13 of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (ECX) is 1 if the instruction is supported.  
  
> [!NOTE]
>  The value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is always overwritten. After the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> instruction, this intrinsic immediately copies the initial value of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For this reason, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> should point to separate memory locations to avoid unexpected behavior.  
  
 Although you can use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> for low-level thread synchronization, you do not need to synchronize over 128 bits if you can use smaller synchronization functions (such as the other <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> intrinsics) instead. Use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if you want atomic access to a 128-bit value in memory.  
  
 If you run code that uses this intrinsic on hardware that does not support the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> instruction, the results are unpredictable.  
  
 This routine is available only as an intrinsic.  
  
## Example  
 This example uses <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to replace the high word of an array of two 64-bit integers with the sum of its high and low words and to increment the low word. The access to the BigInt.Int array is atomic, but this example uses a single thread and ignores the locking for simplicity.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **BigInt.Int[1] = 34, BigInt.Int[0] = 12**   
## END Microsoft Specific  
 Copyright 2007 by Advanced Micro Devices, Inc. All rights reserved. Reproduced with permission from Advanced Micro Devices, Inc.  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [_InterlockedCompareExchange Intrinsic Functions](../vs140/_interlockedcompareexchange-intrinsic-functions.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)