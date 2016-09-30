---
title: "_InterlockedDecrement Intrinsic Functions"
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
  - "_InterlockedDecrement16_rel_cpp"
  - "_InterlockedDecrement16_acq_cpp"
  - "_InterlockedDecrement16_rel"
  - "_InterlockedDecrement64_acq"
  - "_InterlockedDecrement_nf"
  - "_InterlockedDecrement16_nf"
  - "_InterlockedDecrement64_rel_cpp"
  - "_InterlockedDecrement_rel_cpp"
  - "_InterlockedDecrement16_acq"
  - "_InterlockedDecrement64_acq_cpp"
  - "_InterlockedDecrement_rel"
  - "_InterlockedDecrement64_nf"
  - "_InterlockedDecrement16_cpp"
  - "_InterlockedDecrement64"
  - "_InterlockedDecrement_cpp"
  - "_InterlockedDecrement64_rel"
  - "_InterlockedDecrement16"
  - "_InterlockedDecrement"
  - "_InterlockedDecrement64_cpp"
  - "_InterlockedDecrement_acq"
  - "_InterlockedDecrement_acq_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InterlockedDecrement64_rel intrinsic"
  - "InterlockedDecrement64 intrinsic"
  - "_InterlockedDecrement16 intrinsic"
  - "_InterlockedDecrement16_acq intrinsic"
  - "_InterlockedDecrement intrinsic"
  - "_InterlockedDecrement_nf intrinsic"
  - "_InterlockedDecrement_acq intrinsic"
  - "_InterlockedDecrement64_rel intrinsic"
  - "_InterlockedDecrement16_rel intrinsic"
  - "InterlockedDecrement intrinsic"
  - "InterlockedDecrement16 intrinsic"
  - "_InterlockedDecrement16_nf intrinsic"
  - "InterlockedDecrement64_acq intrinsic"
  - "_InterlockedDecrement_rel intrinsic"
  - "InterlockedDecrement_acq intrinsic"
  - "_InterlockedDecrement64_acq intrinsic"
  - "_InterlockedDecrement64 intrinsic"
  - "_InterlockedDecrement64_nf intrinsic"
  - "InterlockedDecrement_rel intrinsic"
ms.assetid: 5268fce3-86b5-4b2b-b96c-2e531a3fb9b5
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _InterlockedDecrement Intrinsic Functions
**Microsoft Specific**  
  
 Provides compiler intrinsic support for the Win32 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] [InterlockedDecrement](http://msdn.microsoft.com/library/ms683580.aspx) function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the variable to be decremented.  
  
## Return Value  
 The return value is the resulting decremented value.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>,|ARM|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 There are several variations on <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that vary based on the data types they involve and whether processor-specific acquire or release semantics is used.  
  
 While the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function operates on 32-bit integer values, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operates on 16-bit integer values and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> operates on 64-bit integer values.  
  
 On ARM platforms, use the intrinsics with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> suffixes if you need acquire and release semantics, such as at the beginning and end of a critical section. The intrinsics with an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> ("no fence") suffix do not act as a memory barrier.  
  
 The variable pointed to by the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter must be aligned on a 32-bit boundary; otherwise, this function fails on multiprocessor x86 systems and any non-x86 systems. For more information, see [align](../vs140/align--c---.md).  
  
 These routines are only available as intrinsics.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)