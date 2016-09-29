---
title: "^= Operator (C# Reference)"
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
  - "^=_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "^= operator [C#]"
ms.assetid: 3658ff9a-61cd-467e-ad6b-8fbf1cfbaae4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ^= Operator (C# Reference)
The exclusive-OR assignment operator.  
  
## Remarks  
 An expression of the form  
  
```  
x ^= y  
```  
  
 is evaluated as  
  
```  
x = x ^ y  
```  
  
 except that `x` is only evaluated once. The [^ operator](../vs140/^-operator--csharp-reference-.md) performs a bitwise exclusive-OR operation on integral operands and logical exclusive-OR on [bool](../vs140/bool--csharp-reference-.md) operands.  
  
 The ^= operator cannot be overloaded directly, but user-defined types can overload the [^ operator](../vs140/^-operator--csharp-reference-.md) (see [operator](../vs140/operator--csharp-reference-2.md)).  
  
## Example  
 [!code[csRefOperators#23](../vs140/codesnippet/CSharp/^=-operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)