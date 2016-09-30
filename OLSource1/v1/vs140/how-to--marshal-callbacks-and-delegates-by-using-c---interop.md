---
title: "How to: Marshal Callbacks and Delegates By Using C++ Interop"
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
  - "data marshaling [C++], callbacks and delegates"
  - "C++ Interop, callbacks and delegates"
  - "interop [C++], callbacks and delegates"
  - "delegates [C++], marshaling"
  - "marshaling [C++], callbacks and delegates"
  - "callbacks [C++], marshaling"
ms.assetid: 2313e9eb-5df9-4367-be0f-14b4712d8d2d
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal Callbacks and Delegates By Using C++ Interop
This topic demonstrates the marshalling of callbacks and delegates (the managed version of a callback) between managed and unmanaged code using Visual C++.  
  
 The following code examples use the [managed, unmanaged](../vs140/managed--unmanaged.md) #pragma directives to implement managed and unmanaged functions in the same file, but the functions could also be defined in separate files. Files containing only unmanaged functions do not need to be compiled with the [/clr (Common Language Runtime Compilation) compiler option](../vs140/-clr--common-language-runtime-compilation-.md).  
  
## Example  
 The following example demonstrates how to configure an unmanaged API to trigger a managed delegate. A managed delegate is created and one of the interop methods, \<xref:System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate*>, is used to retrieve the underlying entry point for the delegate. This address is then passed to the unmanaged function, which calls it with no knowledge of the fact that it is implemented as a managed function.  
  
 Notice that is it possible, but not necessary, to pin the delegate using [pin_ptr](../vs140/pin_ptr--c---cli-.md) to prevent it from being re-located or disposed of by the garbage collector. Protection from premature garbage collection is needed, but pinning provides more protection than is necessary, as it prevents collection but also prevents relocation.  
  
 If a delegate is re-located by a garbage collection, it will not affect the underlaying managed callback, so \<xref:System.Runtime.InteropServices.GCHandle.Alloc*> is used to add a reference to the delegate, allowing relocation of the delegate, but preventing disposal. Using GCHandle instead of pin_ptr reduces fragmentation potential of the managed heap.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example is similar to the previous example, but in this case the provided function pointer is stored by the unmanaged API, so it can be invoked at any time, requiring that garbage collection be suppressed for an arbitrary length of time. As a result, the following example uses a global instance of \<xref:System.Runtime.InteropServices.GCHandle*> to prevent the delegate from being relocated, independent of function scope. As discussed in the first example, using pin_ptr is unnecessary for these examples, but in this case wouldn't work anyway, as the scope of a pin_ptr is limited to a single function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)