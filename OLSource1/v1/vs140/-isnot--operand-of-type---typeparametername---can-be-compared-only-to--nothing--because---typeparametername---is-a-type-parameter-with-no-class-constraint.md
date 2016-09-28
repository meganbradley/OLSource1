---
title: "&#39;IsNot&#39; operand of type &#39;&lt;typeparametername&gt;&#39; can be compared only to &#39;Nothing&#39; because &#39;&lt;typeparametername&gt;&#39; is a type parameter with no class constraint"
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
  - "vbc32097"
  - "bc32097"
helpviewer_keywords: 
  - "BC32097"
ms.assetid: 50283a4b-70e3-4e59-9b9b-65e7cacf5ce1
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;IsNot&#39; operand of type &#39;&lt;typeparametername&gt;&#39; can be compared only to &#39;Nothing&#39; because &#39;&lt;typeparametername&gt;&#39; is a type parameter with no class constraint
A type parameter is used as an operand for the [IsNot Operator](../vs140/isnot-operator--visual-basic-.md) when the type parameter is defined without either the [Class (Visual Basic)](assetId:///0777c6e6-46bc-451b-ad70-57b49d4ef4f7) keyword or a specific class name in its constraint list.  
  
 `IsNot` compares two reference types to determine whether they point to different object instances in memory. It cannot take an operand that is not a reference type unless the other operand is [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md).  
  
 **Error ID:** BC32097  
  
### To correct this error  
  
-   If you can require that the type argument supplied to this type parameter always be a reference type, add either the `Class` keyword or a specific class name to the constraint list for the type parameter.  
  
-   If you cannot require that the type argument supplied to this type parameter always be a reference type, remove it from the `IsNot` expression. You cannot compare it to other reference types with the `IsNot` operator.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)