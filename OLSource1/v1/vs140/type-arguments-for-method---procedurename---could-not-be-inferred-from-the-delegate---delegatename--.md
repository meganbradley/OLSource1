---
title: "Type arguments for method &#39;&lt;procedurename&gt;&#39; could not be inferred from the delegate &#39;&lt;delegatename&gt;&#39;"
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
  - "vbc30952"
  - "bc30952"
helpviewer_keywords: 
  - "BC30952"
ms.assetid: 5eb804ce-2e93-4668-b655-7fe00815e552
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type arguments for method &#39;&lt;procedurename&gt;&#39; could not be inferred from the delegate &#39;&lt;delegatename&gt;&#39;
An assignment statement uses `AddressOf` to assign the address of a generic procedure to a delegate, but it does not supply any type arguments to the generic procedure.  
  
 Normally, when you invoke a generic type, you supply a type argument for each type parameter that the generic type defines. If you do not supply any type arguments, the compiler attempts to infer the types to be passed to the type parameters. If the context does not provide enough information for the compiler to infer the types, it generates an error.  
  
 **Error ID:** BC30952  
  
### To correct this error  
  
-   Specify the type arguments for the generic procedure in the `AddressOf` expression.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)   
 [Type List](../vs140/type-list--visual-basic-.md)