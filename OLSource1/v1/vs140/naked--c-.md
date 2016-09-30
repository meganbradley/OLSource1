---
title: "Naked (C)"
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
  - "C"
helpviewer_keywords: 
  - "naked keyword [C], storage-class attribute"
  - "naked keyword [C]"
  - "prolog code"
  - "epilog code"
ms.assetid: 23b1209b-93ba-46ad-a60f-2327c1933eaf
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Naked (C)
**Microsoft Specific**  
  
 The naked storage-class attribute is a Microsoft-specific extension to the C language. The compiler generates code without prolog and epilog code for functions declared with the naked storage-class attribute. Naked functions are useful when you need to write your own prolog/epilog code sequences using inline assembler code. Naked functions are useful for writing virtual device drivers.  
  
 For specific information about using the naked attribute, see [Naked Functions](../vs140/naked-functions.md).  
  
 **END Microsoft Specific**  
  
## See Also  
 [C Extended Storage-Class Attributes](../vs140/c-extended-storage-class-attributes.md)