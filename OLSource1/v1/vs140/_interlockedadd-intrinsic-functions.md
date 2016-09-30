---
title: "_InterlockedAdd Intrinsic Functions"
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
  - "_InterlockedAdd64_acq_cpp"
  - "_InterlockedAdd64_acq"
  - "_InterlockedAdd_acq"
  - "_InterlockedAdd_nf"
  - "_InterlockedAdd64_rel"
  - "_InterlockedAdd64"
  - "_InterlockedAdd_cpp"
  - "_InterlockedAdd_rel_cpp"
  - "_InterlockedAdd_rel"
  - "_InterlockedAdd64_rel_cpp"
  - "_InterlockedAdd64_cpp"
  - "_InterlockedAdd_acq_cpp"
  - "_InterlockedAdd64_nf"
  - "_InterlockedAdd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_InterlockedAdd_nf intrinsic"
  - "_InterlockedAdd_rel intrinsic"
  - "_InterlockedAdd intrinsic"
  - "_InterlockedAdd64 intrinsic"
  - "_InterlockedAdd64_acq intrinsic"
  - "_InterlockedAdd64_nf intrinsic"
  - "_InterlockedAdd_acq intrinsic"
  - "_InterlockedAdd64_rel intrinsic"
ms.assetid: 3d319603-ea9c-4fdd-ae61-e52430ccc3b1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedAdd Intrinsic Functions
**Microsoft Specific**  
  
 Perform an atomic addition, which ensures that the operation completes successfully when multiple threads have access to a shared variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the integer to be added to; replaced by the result of the addition.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The value to add.  
  
## Return Value  
 Both functions return the result of the addition.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|ARM|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|ARM|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|ARM|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|ARM|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|ARM|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|ARM|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|ARM|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|ARM|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The versions of these functions with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> suffixes perform an interlocked addition following acquire or release semantics. Acquire semantics means that the result of the operation are made visible to all threads and processors before any subsequent memory reads and writes. Acquire is useful when entering a critical section. Release semantics means that all memory reads and writes are forced to be made visible to all threads and processors before the result of the operation is made visible itself. Release is useful when leaving a critical section. The intrinsics with an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 These routines are only available as intrinsics.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)