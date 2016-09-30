---
title: "Compiler Error CS0217"
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
  - "CS0217"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0217"
ms.assetid: ede61095-6e11-4f4a-8e7d-85e7a3f4fc3d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0217
In order to be applicable as a short circuit operator a user-defined logical operator ('operator') must have the same return type as the type of its 2 parameters.  
  
 If you define an operator for a user-defined type, and then try to use the operator as a short-circuit operator, the user-defined operator must have parameters and return values of the same type. For more information on short-circuit operators, see [&& Operator](../vs140/---operator--csharp-reference-.md) and [&#124;&#124; Operator](../vs140/---operator--csharp-reference-.md).  
  
 The following sample generates CS0217:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Overloadable Operators (C# Programmer's Reference)](../vs140/overloadable-operators--csharp-programming-guide-.md)