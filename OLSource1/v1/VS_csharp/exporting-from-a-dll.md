---
title: "Exporting from a DLL"
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
  - "exporting DLLs [C++], about exporting from DLLs"
  - "exporting functions [C++], DLLs (exporting from)"
  - "exporting DLLs [C++]"
  - "DLLs [C++], exporting from"
  - "DLL exports [C++]"
  - "functions [C++], exporting"
  - "exports table [C++]"
ms.assetid: a08f86c4-5996-460b-ae54-da2b764045f0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exporting from a DLL
A DLL file has a layout very similar to an .exe file, with one important difference — a DLL file contains an exports table. The exports table contains the name of every function that the DLL exports to other executables. These functions are the entry points into the DLL; only the functions in the exports table can be accessed by other executables. Any other functions in the DLL are private to the DLL. The exports table of a DLL can be viewed by using the [DUMPBIN](../VS_csharp/dumpbin-reference.md) tool with the /EXPORTS option.  
  
 You can export functions from a DLL using two methods:  
  
-   Create a module definition (.def) file and use the .def file when building the DLL. Use this approach if you want to [export functions from your DLL by ordinal rather than by name](../VS_csharp/exporting-functions-from-a-dll-by-ordinal-rather-than-by-name.md).  
  
-   Use the keyword **__declspec(dllexport)** in the function's definition.  
  
 When exporting functions with either method, make sure to use the [__stdcall](../VS_csharp/__stdcall.md) calling convention.  
  
## What do you want to do?  
  
-   [Export from a DLL using .def files](../VS_csharp/exporting-from-a-dll-using-def-files.md)  
  
-   [Export from a DLL using __declspec(dllexport)](../VS_csharp/exporting-from-a-dll-using-__declspec-dllexport-.md)  
  
-   [Export and import using AFX_EXT_CLASS](../VS_csharp/exporting-and-importing-using-afx_ext_class.md)  
  
-   [Export C++ functions for use in C-language executables](../VS_csharp/exporting-c---functions-for-use-in-c-language-executables.md)  
  
-   [Export C functions for use in C or C++-language executables](../VS_csharp/exporting-c-functions-for-use-in-c-or-c---language-executables.md)  
  
-   [Export functions from a DLL by ordinal rather than by name](../VS_csharp/exporting-functions-from-a-dll-by-ordinal-rather-than-by-name.md)  
  
-   [Determine which exporting method to use](../VS_csharp/determining-which-exporting-method-to-use.md)  
  
-   [Determine which linking method to use](../VS_csharp/determining-which-linking-method-to-use.md)  
  
-   [Initialize a DLL](../VS_csharp/initializing-a-dll.md)  
  
## What do you want to know more about?  
  
-   [Importing into an application](../VS_csharp/importing-into-an-application.md)  
  
-   [Importing and exporting inline functions](../VS_csharp/importing-and-exporting-inline-functions.md)  
  
-   [Mutual imports](../VS_csharp/mutual-imports.md)  
  
## See Also  
 [Importing and Exporting](../VS_csharp/importing-and-exporting.md)