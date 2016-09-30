---
title: "How to: Marshal Strings Using PInvoke"
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
  - "marshaling [C++], strings"
  - "data marshaling [C++], strings"
  - "platform invoke [C++], strings"
ms.assetid: bcc75733-7337-4d9b-b1e9-b95a98256088
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal Strings Using PInvoke
This topic explains how native functions that accept C-style strings can be called using the CLR string type System::String using .NET Framework Platform Invoke support. Visual C++ programmers are encouraged to use the C++ Interop features instead (when possible) because P/Invoke provides little compile-time error reporting, is not type-safe, and can be tedious to implement. If the unmanaged API is packaged as a DLL, and the source code is not available, then P/Invoke is the only option, but otherwise see [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md).  
  
 Managed and unmanaged strings are laid out differently in memory, so passing strings from managed to unmanaged functions requires the \<xref:System.Runtime.InteropServices.MarshalAsAttribute*> attribute to instruct the compiler to insert the required conversion mechanisms for marshaling the string data correctly and safely.  
  
 As with functions that use only intrinsic data types, \<xref:System.Runtime.InteropServices.DllImportAttribute*> is used to declare managed entry points into the native functions, but--for passing strings--instead of defining these entry points as taking C-style strings, a handle to the \<xref:System.String*> type can be used instead. This prompts the compiler to insert code that performs the required conversion. For each function argument in an unmanaged function that takes a string, the \<xref:System.Runtime.InteropServices.MarshalAsAttribute*> attribute should be used to indicate that the String object should be marshaled to the native function as a C-style string.  
  
## Example  
 The following code consists of a unmanaged and a managed module. The unmanaged module is a DLL that defines a function called TakesAString that accepts a C-style ANSI string in the form of a char*. The managed module is a command-line application that imports the TakesAString function, but defines it as taking a managed System.String instead of a char\*. The \<xref:System.Runtime.InteropServices.MarshalAsAttribute*> attribute is used to indicate how the managed string should be marshaled when TakesAString is called.  
  
 The managed module is compiled with /clr, but /clr:pure works as well.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This technique causes a copy of the string to be constructed on the unmanaged heap, so changes made to the string by the native function will not be reflected in the managed copy of the string.  
  
 Note that no portion of the DLL is exposed to the managed code via the traditional #include directive. In fact, the DLL is accessed at runtime only, so problems with functions imported with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> will not be detected at compile time.  
  
## See Also  
 [Using PInvoke in C++](../vs140/using-explicit-pinvoke-in-c----dllimport-attribute-.md)