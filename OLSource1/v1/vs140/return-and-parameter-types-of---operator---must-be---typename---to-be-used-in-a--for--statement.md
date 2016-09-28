---
title: "Return and parameter types of &#39;&lt;operator&gt;&#39; must be &#39;&lt;typename&gt;&#39; to be used in a &#39;For&#39; statement"
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
  - "vbc33039"
  - "bc33039"
helpviewer_keywords: 
  - "BC33039"
ms.assetid: 30e8cfa8-c086-474c-a4f0-ad01d01096e2
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Return and parameter types of &#39;&lt;operator&gt;&#39; must be &#39;&lt;typename&gt;&#39; to be used in a &#39;For&#39; statement
A `For` loop specifies a counter variable of a type that does not define the `+` or `-` operator with parameters and return value of its own type.  
  
 The counter variable must be of a type that supports addition (`+`) and subtraction (`-`) operators that operate completely on their containing type. This means both of the operands and the return value must be of the type of the counter variable.  
  
 If you use a numeric data type for the counter variable, the `+` and `-` operators are supported on the containing type. If you use a user-defined class or structure, you must define both operators with operands and return value of the type of your class or structure.  
  
 **Error ID:** BC33039  
  
### To correct this error  
  
1.  Make sure the spelling of the counter-variable data type is correct.  
  
2.  If you are using a user-defined class or structure for the counter variable, define `+` and `-` operators that operate completely on that class or structure.  
  
## See Also  
 [For...Next Statements (Visual Basic)](../vs140/for...next-statement--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)