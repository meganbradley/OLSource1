---
title: "Module-Definition (.Def) Files"
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
  - def files
  - module definition files
  - .def files
ms.assetid: 08c0bc28-c5d2-47aa-9624-7fc68bcaa4d8
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Module-Definition (.Def) Files
Module-definition (.def) files provide the linker with information about exports, attributes, and other information about the program to be linked. A .def file is most useful when building a DLL. Because there are [linker options](../vs140/linker-options.md) that can be used instead of module-definition statements, .def files are generally not necessary. You can also use [__declspec(dllexport)](../vs140/exporting-from-a-dll-using-__declspec-dllexport-.md) as a way to specify exported functions.  
  
 You can invoke a .def file during the linker phase with the [/DEF (Specify Module-Definition File)](../vs140/-def--specify-module-definition-file-.md) linker option.  
  
 If you are building an .exe file that has no exports, using a .def file will make your output file larger and slower loading.  
  
 For an example, see [Exporting from a DLL Using DEF Files](../vs140/exporting-from-a-dll-using-def-files.md).  
  
 See the following sections for more information:  
  
-   [Rules for Module-Definition Statements](../vs140/rules-for-module-definition-statements.md)  
  
-   [EXPORTS](../vs140/exports.md)  
  
-   [HEAPSIZE](../vs140/heapsize.md)  
  
-   [LIBRARY](../vs140/library.md)  
  
-   [NAME](../vs140/name--c-c---.md)  
  
-   [SECTIONS](../vs140/sections--c-c---.md)  
  
-   [STACKSIZE](../vs140/stacksize.md)  
  
-   [STUB](../vs140/stub.md)  
  
-   [VERSION](../vs140/version--c-c---.md)  
  
-   [Reserved words](../vs140/reserved-words.md)  
  
## See Also  
 [C/C++ Building Reference](../vs140/c-c---building-reference.md)   
 [Linker Options](../vs140/linker-options.md)   
 [Frequently Asked Questions on Building](assetId:///56a3bb8f-0181-4989-bab4-a07ba950ab08)