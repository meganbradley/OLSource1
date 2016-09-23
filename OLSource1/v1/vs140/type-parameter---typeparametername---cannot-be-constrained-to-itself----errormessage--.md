---
title: "Type parameter &#39;&lt;typeparametername&gt;&#39; cannot be constrained to itself: &#39;&lt;errormessage&gt;&#39;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc32113
  - vbc32113
helpviewer_keywords: 
  - BC32113
ms.assetid: a74128ae-11d0-46bf-8c0b-c7a2bf881d17
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Type parameter &#39;&lt;typeparametername&gt;&#39; cannot be constrained to itself: &#39;&lt;errormessage&gt;&#39;
A constraint list for a type parameter includes that same type parameter.  
  
 A constraint list on a type parameter can specify any number of interfaces and at most one class. A type argument supplied for that type parameter must implement every specified interface and inherit from the specified class. The compiler requires interfaces and classes that are already defined when it encounters a constraint list. A type parameter is not considered as a defined type until it is replaced by a suitable type argument supplied by code creating the generic type.  
  
 **Error ID:** BC32113  
  
### To correct this error  
  
1.  Check the spelling of both the type parameter and the constraints in its constraint list.  
  
2.  If there are no spelling mistakes, remove the type parameter's name from its constraint list. It cannot be constrained to itself.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)