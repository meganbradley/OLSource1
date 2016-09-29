---
title: "Wrong number of type arguments passed to method &#39;&lt;genericprocedurename&gt;&#39;"
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
  - "bc30951"
  - "vbc30951"
helpviewer_keywords: 
  - "BC30951"
ms.assetid: 84c2f0cb-5706-4b4e-967c-0ca35a20913c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Wrong number of type arguments passed to method &#39;&lt;genericprocedurename&gt;&#39;
A generic procedure is called with a number of type arguments that does not match the number of type parameters with which it is defined.  
  
 **Error ID:** BC30951  
  
### To correct this error  
  
-   Supply a type argument for every type parameter defined for the generic procedure.  
  
     -or-  
  
-   Call the generic procedure with no type arguments at all, and let the compiler attempt to infer the type arguments.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)