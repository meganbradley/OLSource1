---
title: "How to: Marshal Arrays Using C++ Interop"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "arrays [C++], marshaling"
  - "marshaling [C++], arrays"
  - "interop [C++], arrays"
  - "C++ Interop, arrays"
  - "data marshaling [C++], arrays"
ms.assetid: c2b37ab1-8acf-4855-ad3c-7d2864826b14
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal Arrays Using C++ Interop
This topic demonstrates one facet of Visual C++ interoperability. For more information, see [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md).  
  
 The following code examples use the [managed, unmanaged](../vs140/managed--unmanaged.md) #pragma directives to implement managed and unmanaged functions in the same file, but these functions interoperate in the same manner if defined in separate files. Files containing only unmanaged functions do not need to be compiled with [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md).  
  
## Example  
 The following example demonstrates how to pass a managed array to an unmanaged function. The managed function uses [pin_ptr](../vs140/pin_ptr--c---cli-.md) to suppress garbage collection for the array before calling the unmanaged function. By providing the unmanaged function with a pinned pointer into the GC heap, the overhead of making a copy of the array can be avoided. To demonstrate that the unmanaged function is accessing GC heap memory, it modifies the contents of the array and the changes are reflected when the managed function resumes control.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates passing an unmanaged array to a managed function. The managed function accesses the array memory directly (as opposed to creating a managed array and copying the array content), which allows changes made by the managed function to be reflected in the unmanaged function when it regains control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)