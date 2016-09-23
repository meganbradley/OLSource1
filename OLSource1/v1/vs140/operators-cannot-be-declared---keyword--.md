---
title: "Operators cannot be declared &#39;&lt;keyword&gt;&#39;"
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
  - vbc33013
  - bc33013
helpviewer_keywords: 
  - BC33013
ms.assetid: bfd805f4-e30e-4553-9cb7-2690595f0480
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators cannot be declared &#39;&lt;keyword&gt;&#39;
An operator is declared with a keyword that is not valid for operator definitions.  
  
 Every operator must be declared as both [Public (Visual Basic)](../vs140/public--visual-basic-.md) and [Shared (Visual Basic)](../vs140/shared--visual-basic-.md). In addition, a conversion operator must be declared with either [Widening](../vs140/widening--visual-basic-.md) or [Narrowing](../vs140/narrowing--visual-basic-.md), but not both. An operator definition can optionally include the [Overloads](../vs140/overloads--visual-basic-.md) or [Shadows](../vs140/shadows--visual-basic-.md) keywords. No other keywords are permitted in an [Operator Statement](../vs140/operator-statement.md).  
  
 **Error ID:** BC33013  
  
### To correct this error  
  
-   Remove the invalid keyword from the operator definition.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)