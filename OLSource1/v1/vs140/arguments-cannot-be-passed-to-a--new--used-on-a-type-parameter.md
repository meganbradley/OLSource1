---
title: "Arguments cannot be passed to a &#39;New&#39; used on a type parameter"
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
  - "BC32085"
  - "vbc32085"
helpviewer_keywords: 
  - "BC32085"
ms.assetid: a60bf62d-2b2e-4621-b8db-e67720b918fb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arguments cannot be passed to a &#39;New&#39; used on a type parameter
A declaration or assignment statement invokes a generic type and supplies constructor arguments to a type parameter that has the [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) constraint.  
  
 A constraint list on a type parameter can specify that the type argument passed to that type parameter must expose a parameterless constructor that the creating code can access. A type parameter cannot require a constructor that takes parameters, and a type parameter with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> constraint cannot accept such a constructor.  
  
 **Error ID:** BC32085  
  
### To correct this error  
  
-   Remove the argument list following the type argument in the statement invoking the generic type. You cannot pass constructor arguments to the corresponding type parameter.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)