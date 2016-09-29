---
title: "Type or &#39;New&#39; expected"
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
  - "vbc32092"
  - "bc32092"
helpviewer_keywords: 
  - "BC32092"
ms.assetid: b3041c1d-837c-4d58-bbb4-5c46f227b66d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type or &#39;New&#39; expected
A type parameter in the declaration of a generic type introduces a constraint list with the `As` keyword but does not specify a valid constraint.  
  
 A constraint on a type parameter must be a valid class or interface, or one of the keywords `Class`, `Structure`, or `New`. If you specify an invalid constraint or none at all, the compiler generates this error.  
  
 **Error ID:** BC32092  
  
### To correct this error  
  
1.  Determine how the type parameter should be constrained and specify the appropriate constraint in the constraint list.  
  
2.  If you intend to constrain the type parameter by a class or interface, make sure the constraint spells it correctly.  
  
3.  Remember to separate multiple constraints on a single type parameter with commas, and to enclose the constraint list in braces (`{ }`).  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Class (Visual Basic)](assetId:///0777c6e6-46bc-451b-ad70-57b49d4ef4f7)   
 [Structure (Visual Basic)](assetId:///263ce115-ac36-4c05-8cb7-0e0eead5c6d0)   
 [New (Visual Basic)](../vs140/new-operator--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)