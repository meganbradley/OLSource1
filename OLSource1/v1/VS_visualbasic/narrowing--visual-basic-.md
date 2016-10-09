---
title: "Narrowing (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.narrowing"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "conversions, type"
  - "type conversion"
  - "conversions, data type"
  - "Narrowing keyword"
  - "data type conversion"
ms.assetid: a207ee91-aca4-4771-b4e2-713f029bf2bb
caps.latest.revision: 10
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Narrowing (Visual Basic)
Indicates that a conversion operator (`CType`) converts a class or structure to a type that might not be able to hold some of the possible values of the original class or structure.  
  
## Converting with the Narrowing Keyword  
 The conversion procedure must specify `Public Shared` in addition to `Narrowing`.  
  
 Narrowing conversions do not always succeed at run time, and can fail or incur data loss. Examples are `Long` to `Integer`, `String` to `Date`, and a base type to a derived type. This last conversion is narrowing because the base type might not contain all the members of the derived type and thus is not an instance of the derived type.  
  
 If `Option Strict` is `On`, the consuming code must use `CType` for all narrowing conversions.  
  
 The `Narrowing` keyword can be used in this context:  
  
 [Operator Statement](../VS_visualbasic/operator-statement.md)  
  
## See Also  
 [Operator Statement](../VS_visualbasic/operator-statement.md)   
 [Widening](../VS_visualbasic/widening--visual-basic-.md)   
 [Widening and Narrowing Conversions](../VS_visualbasic/widening-and-narrowing-conversions--visual-basic-.md)   
 [How to: Define an Operator](../VS_visualbasic/how-to--define-an-operator--visual-basic-.md)   
 [CType Function](../VS_visualbasic/ctype-function--visual-basic-.md)   
 [Option Strict Statement](../VS_visualbasic/option-strict-statement.md)