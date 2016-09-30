---
title: "How to: Marshal Arrays Using PInvoke"
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
  - "marshaling [C++], arrays"
  - "platform invoke [C++], arrays"
  - "interop [C++], arrays"
  - "data marshaling [C++], arrays"
ms.assetid: a1237797-a2da-4df4-984a-6333ed3af406
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal Arrays Using PInvoke
This topic explains how native functions that accept C-style strings can be called using the CLR string type \<xref:System.String*> using .NET Framework Platform Invoke support. Visual C++ programmers are encouraged to use the C++ Interop features instead (when possible) because P/Invoke provides little compile-time error reporting, is not type-safe, and can be tedious to implement. If the unmanaged API is packaged as a DLL and the source code is not available, P/Invoke is the only option (otherwise, see [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)).  
  
## Example  
 Because native and managed arrays are laid out differently in memory, passing them successfully across the managed/unmanaged boundary requires conversion, or marshaling. This topic demonstrates how an array of simple (blitable) items can be passed to native functions from managed code.  
  
 As is true of managed/unmanaged data marshaling in general, the \<xref:System.Runtime.InteropServices.DllImportAttribute*> attribute is used to create a managed entry point for each native function that will be used. In the case of functions that take arrays as arguments, the \<xref:System.Runtime.InteropServices.MarshalAsAttribute*> attribute must be used as well to specify to the compiler how the data will be marshaled. In the following example, the \<xref:System.Runtime.InteropServices.UnmanagedType.LPArray*> enumeration is used to indicate that the managed array will be marshaled as a C-style array.  
  
 The following code consists of an unmanaged and a managed module. The unmanaged module is a DLL that defines a function that accepts an array of integers. The second module is a managed command-line application that imports this function, but defines it in terms of a managed array, and uses the \<xref:System.Runtime.InteropServices.MarshalAsAttribute*> attribute to specify that the array should be converted to a native array when called.  
  
 The managed module is compiled with /clr, but /clr:pure works as well.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Note that no portion of the DLL is exposed to the managed code through the traditional #include directive. In fact, because the DLL is accessed at run time only, problems with functions imported with \<xref:System.Runtime.InteropServices.DllImportAttribute*> will not be detected at compile time.  
  
## See Also  
 [Using PInvoke in C++](../vs140/using-explicit-pinvoke-in-c----dllimport-attribute-.md)