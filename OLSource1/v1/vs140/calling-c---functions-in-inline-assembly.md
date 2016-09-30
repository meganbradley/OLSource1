---
title: "Calling C++ Functions in Inline Assembly"
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
  - "functions [C++], calling in inline assembly"
  - "function calls, C++ functions"
  - "function calls, in inline assembly"
  - "Visual C++, functions"
  - "inline assembly, calling functions"
  - "__asm keyword [C++], calling functions"
ms.assetid: 1f0d1eb3-54cf-45d5-838d-958188616b38
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Calling C++ Functions in Inline Assembly
## Microsoft Specific  
 An <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> block can call only global C++ functions that are not overloaded. If you call an overloaded global C++ function or a C++ member function, the compiler issues an error.  
  
 You can also call any functions declared with **extern "C"** linkage. This allows an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block within a C++ program to call the C library functions, because all the standard header files declare the library functions to have **extern "C"** linkage.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Inline Assembler](../vs140/inline-assembler.md)