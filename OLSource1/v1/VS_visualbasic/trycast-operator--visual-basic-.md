---
title: "TryCast Operator (Visual Basic)"
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
  - "vb.trycast"
  - "trycast"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "TryCast keyword"
ms.assetid: d1ef5d47-fef4-491e-b014-1d910628f65c
caps.latest.revision: 17
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
# TryCast Operator (Visual Basic)
Introduces a type conversion operation that does not throw an exception.  
  
## Remarks  
 If an attempted conversion fails, `CType` and `DirectCast` both throw an \<xref:System.InvalidCastException> error. This can adversely affect the performance of your application. `TryCast` returns [Nothing](../VS_visualbasic/nothing--visual-basic-.md), so that instead of having to handle a possible exception, you need only test the returned result against `Nothing`.  
  
 You use the `TryCast` keyword the same way you use the [CType Function](../VS_visualbasic/ctype-function--visual-basic-.md) and the [DirectCast Operator](../VS_visualbasic/directcast-operator--visual-basic-.md) keyword. You supply an expression as the first argument and a type to convert it to as the second argument. `TryCast` operates only on reference types, such as classes and interfaces. It requires an inheritance or implementation relationship between the two types. This means that one type must inherit from or implement the other.  
  
## Errors and Failures  
 `TryCast` generates a compiler error if it detects that no inheritance or implementation relationship exists. But the lack of a compiler error does not guarantee a successful conversion. If the desired conversion is narrowing, it could fail at run time. If this happens, `TryCast` returns [Nothing](../VS_visualbasic/nothing--visual-basic-.md).  
  
## Conversion Keywords  
 A comparison of the type conversion keywords is as follows.  
  
|||||  
|-|-|-|-|  
|Keyword|Data types|Argument relationship|Run-time failure|  
|[CType Function](../VS_visualbasic/ctype-function--visual-basic-.md)|Any data types|Widening or narrowing conversion must be defined between the two data types|Throws \<xref:System.InvalidCastException>|  
|[DirectCast Operator](../VS_visualbasic/directcast-operator--visual-basic-.md)|Any data types|One type must inherit from or implement the other type|Throws \<xref:System.InvalidCastException>|  
|`TryCast`|Reference types only|One type must inherit from or implement the other type|Returns [Nothing](../VS_visualbasic/nothing--visual-basic-.md)|  
  
## Example  
 The following example shows how to use `TryCast`.  
  
 [!code[VbVbalrKeywords#6](../VS_visualbasic/codesnippet/VisualBasic/trycast-operator--visual-basic-_1.vb)]  
  
## See Also  
 [Widening and Narrowing Conversions](../VS_visualbasic/widening-and-narrowing-conversions--visual-basic-.md)   
 [Implicit and Explicit Conversions](../VS_visualbasic/implicit-and-explicit-conversions--visual-basic-.md)