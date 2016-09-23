---
title: "Operators must be declared &#39;Public&#39;"
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
  - vbc33011
  - bc33011
helpviewer_keywords: 
  - BC33011
ms.assetid: 67fc0dee-4ef5-4afc-a63a-f7d20bce7954
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators must be declared &#39;Public&#39;
An [Operator Statement](../vs140/operator-statement.md) does not include the [Public (Visual Basic)](../vs140/public--visual-basic-.md) keyword.  
  
 An `Operator` procedure requires both the `Public` and [Shared (Visual Basic)](../vs140/shared--visual-basic-.md) keywords, and a conversion operator also requires either the [Widening](../vs140/widening--visual-basic-.md) or the [Narrowing](../vs140/narrowing--visual-basic-.md) keyword.  
  
 **Error ID:** BC33011  
  
### To correct this error  
  
-   Add the `Public` keyword to the `Operator` statement.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)