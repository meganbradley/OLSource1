---
title: "How to: Marshal ANSI Strings Using C++ Interop"
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
  - "interop [C++], strings"
  - "ANSI [C++], marshaling strings"
  - "marshaling [C++], strings"
  - "C++ Interop, strings"
  - "data marshaling [C++], strings"
ms.assetid: 5eda2eb6-5140-40f0-82cf-7ce171fffb45
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal ANSI Strings Using C++ Interop
This topic demonstrates how ANSI strings can be passed using C++ Interop, but the .NET Framework \<xref:System.String*> represents strings in Unicode format, so conversion to ANSI is an extra step. For interoperating with other string types, see the following topics:  
  
-   [How to: Marshal Unicode Strings using C++ Interop](../vs140/how-to--marshal-unicode-strings-using-c---interop.md)  
  
-   [How to: Marshal COM Strings using C++ Interop](../vs140/how-to--marshal-com-strings-using-c---interop.md)  
  
 The following code examples use the [managed, unmanaged](../vs140/managed--unmanaged.md) #pragma directives to implement managed and unmanaged functions in the same file, but these functions interoperate in the same manner if defined in separate files. Because files containing only unmanaged functions do not need to be compiled with [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md), they can retain their performance characteristics.  
  
## Example  
 The example demonstrates passing an ANSI string from a managed to an unmanaged function using \<xref:System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi*>. This method allocates memory on the unmanaged heap and returns the address after performing the conversion. This means that no pinning is necessary (because memory on the GC heap is not being passed to the unmanaged function) and that the IntPtr returned from \<xref:System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi*> must be explicitly released or a memory leak results.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates the data marshaling required to access an ANSI string in a managed function that is called by an unmanaged function. The managed function, on receiving the native string, can either use it directly or convert it to a managed string using the \<xref:System.Runtime.InteropServices.Marshal.PtrToStringAnsi*> method, as shown.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)