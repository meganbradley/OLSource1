---
title: "Linking an Executable to a DLL"
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
  - run time [C++], linking
  - dynamic load linking [C++]
  - linking [C++], DLLs
  - DLLs [C++], linking
  - implicit linking [C++]
  - explicit linking [C++]
  - executable files [C++], linking to DLLs
  - loading DLLs [C++]
ms.assetid: 7592e276-dd6e-4a74-90c8-e1ee35598ea3
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linking an Executable to a DLL
An executable file links to (or loads) a DLL in one of two ways:  
  
-   [Implicit linking](../vs140/linking-implicitly.md)  
  
-   [Explicit linking](../vs140/linking-explicitly.md)  
  
 Implicit linking is sometimes referred to as static load or load-time dynamic linking. Explicit linking is sometimes referred to as dynamic load or run-time dynamic linking.  
  
 With implicit linking, the executable using the DLL links to an import library (.lib file) provided by the maker of the DLL. The operating system loads the DLL when the executable using it is loaded. The client executable calls the DLL's exported functions just as if the functions were contained within the executable.  
  
 With explicit linking, the executable using the DLL must make function calls to explicitly load and unload the DLL and to access the DLL's exported functions. The client executable must call the exported functions through a function pointer.  
  
 An executable can use the same DLL with either linking method. Furthermore, these mechanisms are not mutually exclusive, as one executable can implicitly link to a DLL and another can attach to it explicitly.  
  
## What do you want to know more about?  
  
-   [Working with Import Libraries and Export Files](../vs140/working-with-import-libraries-and-export-files.md)  
  
-   [Determining which linking method to use](../vs140/determining-which-linking-method-to-use.md)  
  
-   [The search path used by Windows to locate a DLL](../vs140/search-path-used-by-windows-to-locate-a-dll.md)  
  
## See Also  
 [DLLs in Visual C++](../vs140/dlls-in-visual-c--.md)