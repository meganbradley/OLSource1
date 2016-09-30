---
title: "Using Explicit PInvoke in C++ (DllImport Attribute)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "marshaling [C++], platform invoke"
  - "C++ Interop, platform invoke"
  - "interop [C++], platform invoke"
  - "platform invoke [C++], marshaling in C++"
  - "data marshaling [C++], platform invoke"
ms.assetid: 18e5218c-6916-48a1-a127-f66e22ef15fc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Explicit PInvoke in C++ (DllImport Attribute)
The .NET Framework provides explicit Platform Invoke (or PInvoke) features with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> attribute to allow managed applications to call unmanaged functions packaged inside DLLs. Explicit PInvoke is required for situations where unmanaged APIs are packaged as DLLs and the source code is not available. Calling Win32 functions, for example, requires PInvoke. Otherwise, use implicit P{Invoke; see [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md) for more information.  
  
 PInvoke works by using \<xref:System.Runtime.InteropServices.DllImportAttribute*>. This attribute, which takes the name of the DLL as its first argument, is placed before a function declaration for each DLL entry point that will be used. The signature of the function must match the name of a function exported by the DLL (but some type conversion can be performed implicitly by defining the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> declarations in terms of managed types.)  
  
 The result is a managed entry point for each native DLL function that contains the necessary transition code (or thunk) and simple data conversions. Managed functions can then call into the DLL through these entry points. The code inserted into a module as the result of PInvoke is entirely managed and explicit PInvoke is supported for **/clr**, **/clr:pure**, and **/clr:safe** compilations. For more information, see [Mixed/Pure/Verifiable](../vs140/pure-and-verifiable-code--c---cli-.md).  
  
## In This Section  
  
-   [Platform Invocation Services](../vs140/calling-native-functions-from-managed-code.md)  
  
-   [How to: Call Native DLLs from Managed Code using P/Invoke](../vs140/how-to--call-native-dlls-from-managed-code-using-pinvoke.md)  
  
-   [How to: Marshal Strings using P/Invoke)](../vs140/how-to--marshal-strings-using-pinvoke.md)  
  
-   [How to: Marshal Structures using P/Invoke](../vs140/how-to--marshal-structures-using-pinvoke.md)  
  
-   [How to: Marshal Arrays using P/Invoke](../vs140/how-to--marshal-arrays-using-pinvoke.md)  
  
-   [How to: Marshal Function Pointers using P/Invoke](../vs140/how-to--marshal-function-pointers-using-pinvoke.md)  
  
-   [How to: Marshal Embedded Pointers using P/Invoke](../vs140/how-to--marshal-embedded-pointers-using-pinvoke.md)  
  
## See Also  
 [Platform Invocation Services](../vs140/calling-native-functions-from-managed-code.md)