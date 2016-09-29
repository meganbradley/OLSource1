---
title: "Only conversion operators can be declared &#39;&lt;keyword&gt;&#39;"
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
  - "bc33019"
  - "vbc33019"
helpviewer_keywords: 
  - "BC33019"
ms.assetid: 946266fe-a909-41b1-aad4-f85dc8050b88
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Only conversion operators can be declared &#39;&lt;keyword&gt;&#39;
An [Operator Statement](../vs140/operator-statement.md) specifies [Widening](../vs140/widening--visual-basic-.md) or [Narrowing](../vs140/narrowing--visual-basic-.md) when the operator is not a conversion operator.  
  
 Every operator must be declared as both [Public (Visual Basic)](../vs140/public--visual-basic-.md) and [Shared (Visual Basic)](../vs140/shared--visual-basic-.md). However, only a conversion operator can be declared with [Widening](../vs140/widening--visual-basic-.md) or [Narrowing](../vs140/narrowing--visual-basic-.md), but not both.  
  
 An operator definition can optionally include the [Overloads](../vs140/overloads--visual-basic-.md) and [Shadows](../vs140/shadows--visual-basic-.md) keywords. No other keywords are permitted in an [Operator Statement](../vs140/operator-statement.md).  
  
 **Error ID:** BC33019  
  
### To correct this error  
  
1.  Remove the `Widening` or `Narrowing` keyword from the operator definition. These do not apply, because no type conversion is taking place.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)