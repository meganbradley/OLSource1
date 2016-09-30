---
title: "How to: Marshal Embedded Pointers Using PInvoke"
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
  - "embedded pointers [C++]"
  - "interop [C++], embedded pointers"
  - "platform invoke [C++], embedded pointers"
  - "marshaling [C++], embedded pointers"
  - "data marshaling [C++], embedded pointers"
ms.assetid: f12c1b9a-4f82-45f8-83c8-3fc9321dbb98
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal Embedded Pointers Using PInvoke
Functions that are implemented in unmanaged DLLs can be called from managed code using Platform Invoke (P/Invoke) functionality. If the source code for the DLL is not available, P/Invoke is the only option for interoperating. However, unlike other .NET languages, Visual C++ provides an alternative to P/Invoke. For more information, see [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md) and [How to: Marshal Embedded Pointers Using C++ Interop](../vs140/how-to--marshal-embedded-pointers-using-c---interop.md).  
  
## Example  
 Passing structures to native code requires that a managed structure that is equivalent in terms of data layout to the native structure is created. However, structures that contain pointers require special handling. For each embedded pointer in the native structure, the managed version of the structure should contain an instance of the \<xref:System.IntPtr*> type. Also, memory for these instances must be explicitly allocated, initialized, and released using the \<xref:System.Runtime.InteropServices.Marshal.AllocCoTaskMem*>, \<xref:System.Runtime.InteropServices.Marshal.StructureToPtr*>, and \<xref:System.Runtime.InteropServices.Marshal.FreeCoTaskMem*> methods.  
  
 The following code consists of an unmanaged and a managed module. The unmanaged module is a DLL that defines a function that accepts a structure called ListString that contains a pointer, and a function called TakesListStruct. The managed module is a command-line application that imports the TakesListStruct function and defines a structure called MListStruct that is equivalent to the native ListStruct except that the double* is represented with an \<xref:System.IntPtr*> instance. Before calling TakesListStruct, the main function allocates and initializes the memory that this field references.  
  
 The managed module is compiled with /clr, but /clr:pure works as well.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Note that no portion of the DLL is exposed to the managed code using the traditional #include directive. In fact, the DLL is accessed at run time only, so problems with functions imported with \<xref:System.Runtime.InteropServices.DllImportAttribute*> will not be detected at compile time.  
  
## See Also  
 [Using PInvoke in C++](../vs140/using-explicit-pinvoke-in-c----dllimport-attribute-.md)