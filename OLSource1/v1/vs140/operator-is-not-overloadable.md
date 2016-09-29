---
title: "Operator is not overloadable"
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
  - "vbc33002"
  - "bc33002"
helpviewer_keywords: 
  - "BC33002"
ms.assetid: 8628ea42-57d8-41ca-8bdc-5e4c27be543e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator is not overloadable
Only certain operators are eligible for overloading. The following table lists the operators you can define.  
  
|Type|Operators|  
|----------|---------------|  
|Unary|`+`, `-`, `IsFalse`, `IsTrue`, `Not`|  
|Binary|`+`, `-`, `*`, `/`, `\`, `&`, `^`, `>>`, `<<`, `=`, `<>`, `>`, `>=`, `<`, `<=`, `And`, `Like`, `Mod`, `Or`, `Xor`|  
|Conversion (unary)|`CType`|  
  
 Notice that the `=` operator in the binary list is the comparison operator, not the assignment operator.  
  
 **Error ID:** BC33002  
  
### To correct this error  
  
1.  Select an operator from the set of overloadable operators.  
  
2.  If you need the functionality of overloading an operator that you cannot overload directly, create a `Function` procedure that takes the appropriate parameters and returns the appropriate value.  
  
## See Also  
 [Operator Statement](../vs140/operator-statement.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)