---
title: "Type parameter &#39;&lt;typeparametername&gt;&#39; can only have one constraint that is a class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc32047"
  - "vbc32047"
helpviewer_keywords: 
  - "BC32047"
ms.assetid: ac7ab76b-5300-4c79-b519-5a1287ed5fa9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type parameter &#39;&lt;typeparametername&gt;&#39; can only have one constraint that is a class
A constraint list includes more than one class.  
  
 A constraint list on a type parameter can accept any number of interfaces but at most one class. A type argument supplied for that type parameter must inherit from that class, and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] does not support multiple inheritance.  
  
 **Error ID:** BC32047  
  
### To correct this error  
  
-   Select one class and include only that class in the constraint list.  
  
-   You might be able to define additional type parameters to accommodate the class or classes that you could not include in this constraint list.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)