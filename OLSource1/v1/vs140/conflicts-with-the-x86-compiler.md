---
title: "Conflicts with the x86 Compiler"
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
ms.assetid: 8e47f0d3-afe0-42d9-9efa-de239ddd3a05
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conflicts with the x86 Compiler
Data types that are larger than 4 bytes are not automatically aligned on the stack when you use the x86 compiler to compile an application. Because the architecture for the x86 compiler is a 4 byte aligned stack, anything larger than 4 bytes, for example, a 64-bit integer, cannot be automatically aligned to an 8-byte address.  
  
 Working with unaligned data has two implications.  
  
-   It may take longer to access unaligned locations than it takes to access aligned locations.  
  
-   Unaligned locations cannot be used in interlocked operations.  
  
 If you require more strict alignment, use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. This causes the compiler to dynamically align the stack to meet your specifications. However, dynamically adjusting the stack at run time may cause slower execution of your application.  
  
## See Also  
 [Types and Storage](../vs140/types-and-storage.md)   
 [align (C++)](../vs140/align--c---.md)