---
title: "&#39;New&#39; cannot be used on an interface"
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
  - "vbc30375"
  - "bc30375"
helpviewer_keywords: 
  - "BC30375"
ms.assetid: c1e06108-1b52-4cbe-8cae-e816a0dbac0b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;New&#39; cannot be used on an interface
A [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md) uses a [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) clause when declaring a variable to be of an interface type.  
  
 Although an interface is a reference type, you cannot create an instance of it. You can use `New` only to create an instance of a class or a structure.  
  
 **Error ID:** BC30375  
  
### To correct this error  
  
1.  If the variable is to be of an interface type, remove the `New` keyword.  
  
2.  If the variable is to refer to an instance, declare it to be of a class or structure type. Retain the `New` keyword to create an instance.  
  
## See Also  
 [Interface Statement (Visual Basic)](../vs140/interface-statement--visual-basic-.md)   
 [Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md)   
 [Structure Statement](../vs140/structure-statement.md)