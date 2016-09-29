---
title: "Underflow of Floating-Point Values"
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
ms.assetid: 78af8016-643c-47db-b4f1-7f06cb4b243e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Underflow of Floating-Point Values
**ANSI 4.5.1** Whether the mathematics functions set the integer expression `errno` to the value of the macro `ERANGE` on underflow range errors  
  
 A floating-point underflow does not set the expression `errno` to `ERANGE`. When a value approaches zero and eventually underflows, the value is set to zero.  
  
## See Also  
 [Library Functions](../vs140/library-functions.md)