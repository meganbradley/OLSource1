---
title: "_ReadWriteBarrier"
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
  - "_ReadWriteBarrier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReadWriteBarrier intrinsic"
  - "_ReadWriteBarrier intrinsic"
ms.assetid: dd9f58b5-8bb6-494e-bb0f-9fe184f3908d
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ReadWriteBarrier
**Microsoft Specific**  
  
 Limits the compiler optimizations that can reorder memory accesses across the point of the call.  
  
> [!CAUTION]
>  The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> compiler intrinsics and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro are all deprecated and should not be used. For inter-thread communication, use mechanisms such as [atomic_thread_fence](../vs140/atomic_thread_fence-function.md) and [std::atomic\<T>](../vs140/-atomic-.md), which are defined in the [C++ Standard Template Library](../vs140/c---standard-library-reference.md). For hardware access, use the [/volatile:iso](../vs140/-volatile--volatile-keyword-interpretation-.md) compiler option together with the [volatile](../vs140/volatile--c---.md) keyword.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> intrinsic limits the compiler optimizations that can remove or reorder memory accesses across the point of the call.  
  
## END Microsoft Specific  
  
## See Also  
 [_ReadBarrier](../vs140/_readbarrier.md)   
 [_WriteBarrier](../vs140/_writebarrier.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)