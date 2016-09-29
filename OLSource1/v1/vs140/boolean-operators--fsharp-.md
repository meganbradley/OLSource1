---
title: "Boolean Operators (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Boolean operators [F#]"
  - "&& operator [F#]"
  - "|| operator [F#]"
  - "not operator [F#]"
  - "operators [F#], Boolean"
ms.assetid: 65a2742d-7265-4681-8793-8e940b3adcf0
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Boolean Operators (F#)
This topic describes the support for Boolean operators in the F# language.  
  
## Summary of Boolean Operators  
 The following table summarizes the Boolean operators that are available in the F# language. The only type supported by these operators is the `bool` type.  
  
|Operator|Description|  
|--------------|-----------------|  
|`not`|Boolean negation|  
|`&#124;&#124;`|Boolean OR|  
|`&&`|Boolean AND|  
  
 The Boolean AND and OR operators perform *short-circuit evaluation*, that is, they evaluate the expression on the right of the operator only when it is necessary to determine the overall result of the expression. The second expression of the `&&` operator is evaluated only if the first expression evaluates to `true`; the second expression of the `||` operator is evaluated only if the first expression evaluates to `false`.  
  
## See Also  
 [Bitwise Operators](../vs140/bitwise-operators--fsharp-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)   
 [Symbol and Operator Reference](../vs140/symbol-and-operator-reference--fsharp-.md)