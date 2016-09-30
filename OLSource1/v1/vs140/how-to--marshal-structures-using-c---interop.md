---
title: "How to: Marshal Structures Using C++ Interop"
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
  - "C++ Interop, structures"
  - "structures [C++], marshaling"
  - "data marshaling [C++], structures"
  - "interop [C++], structures"
  - "marshaling [C++], structures"
ms.assetid: c2080200-f983-4d6e-a557-cd870f060a54
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal Structures Using C++ Interop
This topic demonstrates one facet of Visual C++ interoperability. For more information, see [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md).  
  
 The following code examples use the [managed, unmanaged](../vs140/managed--unmanaged.md) #pragma directives to implement managed and unmanaged functions in the same file, but these functions interoperate in the same manner if defined in separate files. Files containing only unmanaged functions do not need to be compiled with [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md).  
  
## Example  
 The following example demonstrates passing a structure from a managed to an unmanaged function, both by value and by reference. Because the structure in this example contains only simple, intrinsic data types (see [Blittable and Non-Blittable Types](assetId:///d03b050e-2916-49a0-99ba-f19316e5c1b3)), no special marshaling is required. To marshal non-blittable structures, such as those that contain pointers, see [How to: Marshal Embedded Pointers (C++ Interop)](../vs140/how-to--marshal-embedded-pointers-using-c---interop.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates passing a structure from an unmanaged to a managed function, both by value and by reference. Because the structure in this example contains only simple, intrinsic data types (see [Blittable and Non-Blittable Types](assetId:///d03b050e-2916-49a0-99ba-f19316e5c1b3)), no special marshalling is required. To marshal non-blittable structures, such as those that contain pointers, see [How to: Marshal Embedded Pointers (C++ Interop)](../vs140/how-to--marshal-embedded-pointers-using-c---interop.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)