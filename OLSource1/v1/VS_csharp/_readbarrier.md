---
title: "_ReadBarrier"
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
  - "_ReadBarrier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ReadBarrier intrinsic"
ms.assetid: f9e54a92-61bc-4f55-8195-b8932065a796
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ReadBarrier
**Microsoft Specific**  
  
 Limits the compiler optimizations that can reorder memory access operations across the point of the call.  
  
> [!CAUTION]
>  The `_ReadBarrier`, `_WriteBarrier`, and `_ReadWriteBarrier` compiler intrinsics and the `MemoryBarrier` macro are all deprecated and should not be used. For inter-thread communication, use mechanisms such as [atomic_thread_fence](../Topic/atomic_thread_fence%20Function.md) and [std::atomic<T\>](../VS_csharp/-atomic-.md) that are defined in the [C++ Standard Template Library](../VS_csharp/c---standard-library-reference.md). For hardware access, use the [/volatile:iso](../VS_csharp/-volatile--volatile-keyword-interpretation-.md) compiler option together with the [volatile](../VS_csharp/volatile--c---.md) keyword.  
  
## Syntax  
  
```  
void _ReadBarrier(void);  
```  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|`_ReadBarrier`|x86, [!INCLUDE[vcprx64](../VS_csharp/includes/vcprx64_md.md)]|  
  
 **Header file** <intrin.h>  
  
## Remarks  
 The `_ReadBarrier` intrinsic limits the compiler optimizations that can remove or reorder memory access operations across the point of the call.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../VS_csharp/compiler-intrinsics.md)   
 [Keywords](../VS_csharp/keywords--c---.md)