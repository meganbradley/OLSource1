---
title: "Widening (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.widening
dev_langs: 
  - VB
helpviewer_keywords: 
  - conversions, type
  - type conversion
  - conversions, data type
  - Widening keyword
  - data type conversion
ms.assetid: 646ae263-94d3-40a2-b0cc-64f619292f56
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Widening (Visual Basic)
Indicates that a conversion operator (`CType`) converts a class or structure to a type that can hold all possible values of the original class or structure.  
  
## Converting with the Widening Keyword  
 The conversion procedure must specify `Public Shared` in addition to `Widening`.  
  
 Widening conversions always succeed at run time and never incur data loss. Examples are `Single` to `Double`, `Char` to `String`, and a derived type to its base type. This last conversion is widening because the derived type contains all the members of the base type and thus is an instance of the base type.  
  
 The consuming code does not have to use `CType` for widening conversions, even if `Option Strict` is `On`.  
  
 The `Widening` keyword can be used in this context:  
  
 [Operator Statement](../vs140/operator-statement.md)  
  
 For example definitions of widening and narrowing conversion operators, see [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md).  
  
## See Also  
 [Operator Statement](../vs140/operator-statement.md)   
 [Narrowing](../vs140/narrowing--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [CType Function](../vs140/ctype-function--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)