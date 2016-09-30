---
title: "How to: Marshal Structures Using PInvoke"
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
  - "data marshaling [C++], structures"
  - "platform invoke [C++], structures"
  - "interop [C++], structures"
  - "marshaling [C++], structures"
ms.assetid: 35997e6f-9251-4af3-8c6e-0712d64d6a5d
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal Structures Using PInvoke
This document explains how native functions that accept C-style strings can be called from managed functions that provide an instance of \<xref:System.String*> by using P/Invoke. Although we recommend that you use the C++ Interop features instead of P/Invoke because P/Invoke provides little compile-time error reporting, is not type-safe, and can be tedious to implement, if the unmanaged API is packaged as a DLL and the source code is not available, P/Invoke is the only option. Otherwise, see the following documents:  
  
-   [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)  
  
-   [How to: Marshal Structures Using PInvoke](../vs140/how-to--marshal-structures-using-pinvoke.md)  
  
 By default, native and managed structures are laid out differently in memory, so successfully passing structures across the managed/unmanaged boundary requires extra steps to preserve data integrity.  
  
 This document explains the steps required to define managed equivalents of native structures and how the resulting structures can be passed to unmanaged functions. This document assumes that simple structures — those that do not contain strings or pointers — are used. For information about non-blittable interoperability, see [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md). P/Invoke cannot have non-blittable types as a return value. Blittable types have the same representation in managed and unmanaged code. For more information, see [Blittable and Non-Blittable Types](assetId:///d03b050e-2916-49a0-99ba-f19316e5c1b3).  
  
 Marshaling simple, blittable structures across the managed/unmanaged boundary first requires that managed versions of each native structure be defined. These structures can have any legal name; there is no relationship between the native and managed version of the two structures other than their data layout. Therefore, it is vital that the managed version contains fields that are the same size and in the same order as the native version. (There is no mechanism for ensuring that the managed and native versions of the structure are equivalent, so incompatibilities will not become apparent until run time. It is the programmer's responsibility to ensure that the two structures have the same data layout.)  
  
 Because the members of managed structures are sometimes rearranged for performance purposes, it is necessary to use the \<xref:System.Runtime.InteropServices.StructLayoutAttribute*> attribute to indicate that the structure are laid out sequentially. It is also a good idea to explicitly set the structure packing setting to be the same as that used by the native structure. (Although by default, Visual C++ uses an 8-byte structure packing for both managed code.)  
  
1.  Next, use \<xref:System.Runtime.InteropServices.DllImportAttribute*> to declare entry points that correspond to any unmanaged functions that accept the structure, but use the managed version of the structure in the function signatures, which is a moot point if you use the same name for both versions of the structure.  
  
2.  Now managed code can pass the managed version of the structure to the unmanaged functions as though they are actually managed functions. These structures can be passed either by value or by reference, as demonstrated in the following example.  
  
## Example  
 The following code consists of an unmanaged and a managed module. The unmanaged module is a DLL that defines a structure called Location and a function called GetDistance that accepts two instances of the Location structure. The second module is a managed command-line application that imports the GetDistance function, but defines it in terms of a managed equivalent of the Location structure, MLocation. In practice the same name would probably be used for both versions of the structure; however, a different name is used here to demonstrate that the DllImport prototype is defined in terms of the managed version.  
  
 The managed module is compiled with /clr, but /clr:pure works as well.  
  
 Note that no portion of the DLL is exposed to the managed code using the traditional #include directive. In fact, the DLL is accessed at run time only, so problems with functions imported with DllImport will not be detected at compile time.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **[unmanaged] loc1(0,0) loc2(100,100)**  
**[managed] distance = 141.42135623731**  
**[unmanaged] Initializing location...**  
**[managed] x=50 y=50**   
## See Also  
 [Using PInvoke in C++](../vs140/using-explicit-pinvoke-in-c----dllimport-attribute-.md)