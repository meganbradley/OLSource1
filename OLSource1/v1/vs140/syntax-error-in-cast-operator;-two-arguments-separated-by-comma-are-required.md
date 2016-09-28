---
title: "Syntax error in cast operator; two arguments separated by comma are required"
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
  - "vbc30944"
  - "bc30944"
helpviewer_keywords: 
  - "BC30944"
ms.assetid: 1f7ed4a1-6ff5-4836-8424-21618c68ff45
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Syntax error in cast operator; two arguments separated by comma are required
An expression uses the `CType` conversion function or the `DirectCast` or `TryCast` conversion keyword but supplies only one argument.  
  
 `CType`, `DirectCast`, and `TryCast` all require two arguments. The first is an expression to be converted and the second is the data type or class type to which to convert it.  
  
 **Error ID:** BC30944  
  
### To correct this error  
  
-   Supply both arguments as required for the conversion.  
  
-   If you intend to use one of the specific [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md) such as `CString`, you must use that function name instead of `CType`. Then only one argument is required.  
  
## See Also  
 [CType Function](../vs140/ctype-function--visual-basic-.md)   
 [DirectCast](../vs140/directcast-operator--visual-basic-.md)   
 [TryCast](../vs140/trycast-operator--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)