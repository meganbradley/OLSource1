---
title: "Importing and Exporting Inline Functions"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - exporting functions [C++], inline functions
  - inline functions [C++], importing
  - DLLs [C++], importing
  - importing functions [C++]
  - DLLs [C++], exporting from
  - importing inline functions [C++]
  - inline functions [C++], exporting
  - functions [C++], importing
  - functions [C++], exporting
ms.assetid: 89f488f8-b078-40fe-afd7-80bd7840057b
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Importing and Exporting Inline Functions
Imported functions can be defined as inline. The effect is roughly the same as defining a standard function inline; calls to the function are expanded into inline code, much like a macro. This is principally useful as a way of supporting C++ classes in a DLL that might inline some of their member functions for efficiency.  
  
 One feature of an imported inline function is that you can take its address in C++. The compiler returns the address of the copy of the inline function residing in the DLL. Another feature of imported inline functions is that you can initialize static local data of the imported function, unlike global imported data.  
  
> [!CAUTION]
>  You should exercise care when providing imported inline functions because they can create the possibility of version conflicts. An inline function gets expanded into the application code; therefore, if you later rewrite the function, it does not get updated unless the application itself is recompiled. (Normally, DLL functions can be updated without rebuilding the applications that use them.)  
  
## What do you want to do?  
  
-   [Export from a DLL](../vs140/exporting-from-a-dll.md)  
  
-   [Export from a DLL using .DEF files](../vs140/exporting-from-a-dll-using-def-files.md)  
  
-   [Export from a DLL using __declspec(dllexport)](../vs140/exporting-from-a-dll-using-__declspec-dllexport-.md)  
  
-   [Export and import using AFX_EXT_CLASS](../vs140/exporting-and-importing-using-afx_ext_class.md)  
  
-   [Export C++ functions for use in C-language executables](../vs140/exporting-c---functions-for-use-in-c-language-executables.md)  
  
-   [Determine which exporting method to use](../vs140/determining-which-exporting-method-to-use.md)  
  
-   [Import into an application using __declspec(dllimport)](../vs140/importing-into-an-application-using-__declspec-dllimport-.md)  
  
## See Also  
 [Importing and Exporting](../vs140/importing-and-exporting.md)