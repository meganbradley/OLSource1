---
title: "Operator &#39;&lt;operator&gt;&#39; must have a return type of Boolean"
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
  - "vbc33023"
  - "bc33023"
helpviewer_keywords: 
  - "BC33023"
ms.assetid: 18e066f4-d71e-4e38-b0bc-8af9145f6015
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator &#39;&lt;operator&gt;&#39; must have a return type of Boolean
A comparison or logical operator is declared with a return type other than the [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md).  
  
 The result of a comparison operator (`=`, `<>`, `<`, `<=`, `>`, `>=`, `Is`, `IsNot`, `IsFalse`, `IsTrue`, `Like`, `TypeOf`) can be only `True` or `False`. For more information, see [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md).  
  
 Logical operators (`And`, `AndAlso`, `Not`, `Or`, `OrElse`, `Xor`) work entirely within the domain of Boolean values. For more information, see [Logical Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md).  
  
 **Error ID:** BC33023  
  
### To correct this error  
  
-   Replace the return type of this comparison or logical operator with `Boolean`.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)