---
title: "Compiler Warning (level 1) C4503"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4503"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4503"
ms.assetid: 7c5a98ae-5b6d-41d8-b881-12d3ffd5e392
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4503
'identifier' : decorated name length exceeded, name was truncated  
  
 The decorated name was longer than the compiler limit (4096), and was truncated. To avoid this warning and the truncation, reduce the number of arguments or name length of identifiers used.  
  
 One situation where this warning will be issued is when your code contains templates specialized on templates repeatedly.  For example, a map of maps (from the Standard C++ Library).  In this situation, you can make your typedefs a type (struct, for example) that contains the map.  
  
 You might, however, decide to not restructure your code.  It is possible to ship an application that generates C4503, but if you get link time errors on a truncated symbol, it will be more difficult to determine the type of the symbol in the error.  Debugging will also be more difficult; the debugger will also have difficultly mapping symbol name to type name.  The correctness of the program, however, is unaffected by the truncated name.  
  
 The following sample generates C4503:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample shows one way to rewrite your code to resolve C4503:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>