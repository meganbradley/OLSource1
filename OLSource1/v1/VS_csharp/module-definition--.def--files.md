---
title: "Module-Definition (.Def) Files"
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
  - "def files"
  - "module definition files"
  - ".def files"
ms.assetid: 08c0bc28-c5d2-47aa-9624-7fc68bcaa4d8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module-Definition (.Def) Files
Module-definition (.def) files provide the linker with information about exports, attributes, and other information about the program to be linked. A .def file is most useful when building a DLL. Because there are [linker options](../VS_csharp/linker-options.md) that can be used instead of module-definition statements, .def files are generally not necessary. You can also use [__declspec(dllexport)](../VS_csharp/exporting-from-a-dll-using-__declspec-dllexport-.md) as a way to specify exported functions.  
  
 You can invoke a .def file during the linker phase with the [/DEF (Specify Module-Definition File)](../VS_csharp/-def--specify-module-definition-file-.md) linker option.  
  
 If you are building an .exe file that has no exports, using a .def file will make your output file larger and slower loading.  
  
 For an example, see [Exporting from a DLL Using DEF Files](../VS_csharp/exporting-from-a-dll-using-def-files.md).  
  
 See the following sections for more information:  
  
-   [Rules for Module-Definition Statements](../VS_csharp/rules-for-module-definition-statements.md)  
  
-   [EXPORTS](../VS_csharp/exports.md)  
  
-   [HEAPSIZE](../VS_csharp/heapsize.md)  
  
-   [LIBRARY](../VS_csharp/library.md)  
  
-   [NAME](../VS_csharp/name--c-c---.md)  
  
-   [SECTIONS](../VS_csharp/sections--c-c---.md)  
  
-   [STACKSIZE](../VS_csharp/stacksize.md)  
  
-   [STUB](../VS_csharp/stub.md)  
  
-   [VERSION](../VS_csharp/version--c-c---.md)  
  
-   [Reserved words](../VS_csharp/reserved-words.md)  
  
## See Also  
 [C/C++ Building Reference](../VS_csharp/c-c---building-reference.md)   
 [Linker Options](../VS_csharp/linker-options.md)   
 [Frequently Asked Questions on Building](assetId:///56a3bb8f-0181-4989-bab4-a07ba950ab08)