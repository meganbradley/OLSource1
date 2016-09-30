---
title: "Compiler Error CS0218"
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
  - "CS0218"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0218"
ms.assetid: f675e06a-c55c-44a1-b5db-0df178fd8f79
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0218
The type ('type') must contain declarations of operator true and operator false  
  
 If you define an operator for a user-defined type, and then try to use the operator as a short-circuit operator, the user-defined operator must have operator true and operator false defined. For more information on short-circuit operators, see [&& Operator](../vs140/---operator--csharp-reference-.md) and [&#124;&#124; Operator](../vs140/---operator--csharp-reference-.md).  
  
 The following sample generates CS0218:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Conversion Operators (C# Programmer's Reference)](../vs140/conversion-operators--csharp-programming-guide-.md)