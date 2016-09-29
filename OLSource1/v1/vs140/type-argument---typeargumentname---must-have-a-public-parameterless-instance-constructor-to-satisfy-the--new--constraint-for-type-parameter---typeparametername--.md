---
title: "Type argument &#39;&lt;typeargumentname&gt;&#39; must have a public parameterless instance constructor to satisfy the &#39;New&#39; constraint for type parameter &#39;&lt;typeparametername&gt;&#39;"
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
  - "vbc32083"
  - "BC32083"
helpviewer_keywords: 
  - "BC32083"
ms.assetid: 56bf25f1-375c-4b5d-9969-45eba8b3b66c
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type argument &#39;&lt;typeargumentname&gt;&#39; must have a public parameterless instance constructor to satisfy the &#39;New&#39; constraint for type parameter &#39;&lt;typeparametername&gt;&#39;
A type argument supplies a type without an accessible parameterless constructor to a type parameter with the [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) constraint.  
  
 A constraint list imposes requirements on the type argument passed to the type parameter. One possible requirement is that the type argument must expose a parameterless constructor that the creating code can access. To specify this requirement, the constraint list includes the `New` constraint.  
  
 **Error ID:** BC32083  
  
### To correct this error  
  
1.  Verify that the generic type name and the type name in the type argument are spelled correctly.  
  
2.  Choose a type for the type argument that exposes an accessible parameterless constructor. You cannot invoke this particular generic type unless you can supply such a type argument to this type parameter.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [How to: Use a Generic Class](../vs140/how-to--use-a-generic-class--visual-basic-.md)