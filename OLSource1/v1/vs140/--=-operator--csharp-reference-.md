---
title: "&lt;&lt;= Operator (C# Reference)"
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
  - "<<=_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "<<= operator (left-shift assignment) [C#]"
  - "left shift assignment operator (<<=) [C#]"
ms.assetid: 3bc99c78-1edb-4827-86fc-bce6c3048871
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;&lt;= Operator (C# Reference)
The left-shift assignment operator.  
  
## Remarks  
 An expression of the form  
  
```  
x <<= y  
```  
  
 is evaluated as  
  
```  
x = x << y  
```  
  
 except that `x` is only evaluated once. The [<< operator](../vs140/---operator--csharp-reference-.md) shifts `x` left by the number of bits specified by `y`.  
  
 The `<<=` operator cannot be overloaded directly, but user-defined types can overload the [<< operator](../vs140/---operator--csharp-reference-.md) (see [operator](../vs140/operator--csharp-reference-2.md)).  
  
## Example  
 [!code[csRefOperators#12](../vs140/codesnippet/CSharp/--=-operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)