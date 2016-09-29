---
title: "&#39;TryCast&#39; operand must be reference type, but &#39;&lt;typename&gt;&#39; is a value type"
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
  - "BC30792"
  - "vbc30792"
helpviewer_keywords: 
  - "BC30792"
ms.assetid: 3325fce5-dbc0-4d1d-9530-31f4720bfe6e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;TryCast&#39; operand must be reference type, but &#39;&lt;typename&gt;&#39; is a value type
The `TryCast` operator is used with a value type for at least one of the arguments.  
  
 `TryCast` tests for an inheritance or implementation relationship between the two arguments. Therefore, it allows only reference types for the arguments. For more information, see [Value Types and Reference Types](../vs140/value-types-and-reference-types.md).  
  
 **Error ID:** BC30792  
  
### To correct this error  
  
-   Use `DirectCast` or `CType` to perform the conversion. They both allow value types.  
  
## See Also  
 [TryCast](../vs140/trycast-operator--visual-basic-.md)   
 [DirectCast](../vs140/directcast-operator--visual-basic-.md)   
 [CType Function](../vs140/ctype-function--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)